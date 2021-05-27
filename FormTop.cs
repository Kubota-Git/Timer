using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class FormTop : MaterialSkin.Controls.MaterialForm
    {
        /*--------------------------------------------------------*/
        /*フィールド①←コード記述の番号(エラーが出ない順番)*/
        /*--------------------------------------------------------*/        
        private bool alarmSetFlag = false;  //アラームセット中フラグ
        private DateTime aramTime = new DateTime(); //アラーム用変数
        private DateTime limitTime = new DateTime();//タイマー用変数
        private DateTime todayTime = DateTime.Now;  //現在時刻1
       

        //アラームストップ用
        private bool alarmStopFlug = false; //アラーム停止フラッグ

        //アラームタイプ切り替え
        private bool alarmType = true;     //タイマーモード:true/アラームモード:false

        //フォーム位置の調整
        Point desktopLocation;//フォーム座標
        int desktopX;// X座標
        int desktopY;// Y座標

        /*--------------------------------------------------------*/
        /*コンストラクタ③*/
        /*--------------------------------------------------------*/
        /*<<ポイント>>*/
        /*役割は初期設定(クラス生成時に持たせたい値を記述)*/
        /*プロパティとは違いインスタンス化した初回のみ実行*/
        /*左辺は変数ではなく、プロパティ名！*/
        /*右辺はフィールド名ではなく、ローカル変数！*/
        /*アクセス演算子はpublic*/
        /*--------------------------------------------------------*/
        public FormTop()
        {
            InitializeComponent();
        }



        /*--------------------------------------------------------*/
        /*メソッド(関数メンバ)④*/
        /*--------------------------------------------------------*/

        private void FormTop_Load(object sender, EventArgs e)
        {
            //フォーム起動時

            //タイマーを起動
            timer1.Start();

            //現在時刻を表示
            materialLabelTimer.Text = todayTime.ToLongTimeString();//文字列に変換

            //スイッチ操作制限
            materialSwitchPageTop.Enabled = false;

            //デスクトップ上の位置を取得
            desktopLocation = this.DesktopLocation;// デスクトップ上の位置を取得
            desktopX = desktopLocation.X;// X座標を取得
            desktopY = desktopLocation.Y;// Y座標を取得

        }

        /*--------------------------------------------------------*/
        /*イベントメソッド(関数メンバ)⑤*/
        /*--------------------------------------------------------*/
        /*--------------------------------------------------------*/
        /*メソッド名：TimeSplit*/
        /*　概　要　：文字を含む時間文字列の数値化*/
        /*　仮引数　：timeType：'時'または'分'等の時間単位
        /*　        ：maxTime：単位時間の最大時間*/
        /*　戻り値　：時間数値部分*/
        /*　特　記　：リスト等からの時間情報を変換する(00時⇒00)*/
        /*--------------------------------------------------------*/
        private int TimeSplit(string timeText, char timeType)
        {
            string[] s = timeText.Split(timeType);
            return int.Parse(s[0]);
        }

        /*--------------------------------------------------------*/
        /*メソッド名：TimeValue*/
        /*　概　要　：文字を含む時間文字列の％数値化*/
        /*　仮引数　：timeType：'時'または'分'等の時間単位
        /*　        ：maxTime：単位時間の最大時間*/
        /*　戻り値　：時間数値を％数値へ変換*/
        /*　特　記　：リスト等からの時間情報を変換する(00時⇒00/24)*/
        /*--------------------------------------------------------*/
        private int TimeValue(string timeText, char timeType, int maxTime)
        {
            double n = (double)TimeSplit(timeText, timeType);//数値の取り出し
            int time = (int)(n / maxTime * 100);
            return time;
        }

        /*--------------------------------------------------------*/
        /*メソッド名：TimeCount*/
        /*　概　要　：時間のカウント加算*/
        /*　仮引数　：time：加算されるDateTime変数
        /*　        ：pulsOrMinus:加算ならばtrue、減算ならばfalse*/
        /*　戻り値　：加算後の時間*/
        /*　特　記　：Timerコンポーネント内で使用することが前提*/
        /*　        ：Interval：1000msに設定*/
        /*--------------------------------------------------------*/
        private DateTime timeCount(DateTime time, bool plusOrMinus)
        {
            int symbol = 1;
            if (plusOrMinus != true)
            {
                symbol *= -1;
            }
            TimeSpan addTime = new TimeSpan(0, 0, symbol);//1秒

            return time.Add(addTime);

        }

        /*--------------------------------------------------------*/
        /*メソッド名：addTimeMethod*/
        /*　概　要　：現在時刻への加算*/
        /*　仮引数　：hour    ：加算したい時
         *　　      ：minut   ：加算したい分
         *　　      ：sec     ：加算したい秒
        /*　戻り値　：加算後の時間*/
        /*　特　記　：メソッドが呼び出される際の時刻取得*/
        /*--------------------------------------------------------*/
        private DateTime addTimeMethod(int hour,int minut,int sec)
        {
            TimeSpan time = new TimeSpan(hour,minut,sec);
            DateTime now = DateTime.Now;

            return now.Add(time);
        }

        private void materialSwitchPageTop_CheckedChanged(object sender, EventArgs e)
        {
            //アラーム設定有無の処理
            if (alarmSetFlag == true)
            {
                materialSwitchPageTop.Enabled = true;

            }

            //スイッチによる操作
            if (materialSwitchPageTop.Checked == true)
            {
                //アラーム作動中(STOPスイッチOFF)
                alarmStopFlug = false;
                materialLabelStatus.Text = "COUNT";

            }
            else
            {
                //アラーム停止中(STOPスイッチON)
                alarmStopFlug = true;       //STOPフラッグを立てる
                materialLabelStatus.Text = "STOP";

            }

        }


        private void materialButtonAramSet_Click(object sender, EventArgs e)
        {
            if(alarmSetFlag != true)//アラーム設定前
            {
                //値の取得
                int hour = TimeSplit(materialComboBoxSetTimeH.Text, '時');
                int minut = TimeSplit(materialComboBoxSetTimeM.Text, '分');

                //アラームの設定
                alarmSetFlag = true;//フラッグON
                DateTime now = DateTime.Now;//現在時刻の取得3

                //アラームモードとタイマーモードの設定
                if (alarmType == true)//タイマーモード時
                {
                    //設定時刻に現在時刻を足して代入                    
                    aramTime = addTimeMethod(hour, minut, 0);
                }
                else//アラームモード時
                {
                    //設定時刻をそのまま代入
                    aramTime = new DateTime(now.Year, now.Month, now.Day,
                                    hour,//設定時
                                    minut,//設定分
                                    0);//設定秒
                }

                //残り時間の設定            
                limitTime = new DateTime(now.Year, now.Month, now.Day,
                                    hour,//設定時
                                    minut,//設定分
                                    0);//設定秒

                //TOPスイッチをONに変更
                materialSwitchPageTop.Checked = true;
                //TOP画面へ切り替え
                tabPageTop.Show();

                //アラーム解除ボタンへ変更
                materialButtonAramSet.Text = "DEL";//操作取り消し
                materialComboBoxSetTimeH.Enabled = false;
                materialComboBoxSetTimeM.Enabled = false;
                materialSliderSetTimeH.Enabled = false;
                materialSliderSetTimeM.Enabled = false;
                materialSwitchSetting.Enabled = false;
                this.materialButtonAramSet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            }
            else//アラーム設定中
            {
                //アラームキャンセル
                alarmSetFlag = false;//アラームOFF

                //スイッチがOFF
                materialSwitchPageTop.Checked = false;

                //アラーム設定可能ボタンへ変更
                materialButtonAramSet.Text = "SET";//操作可能
                materialComboBoxSetTimeH.Enabled = true;
                materialComboBoxSetTimeM.Enabled = true;
                materialSliderSetTimeH.Enabled = true;
                materialSliderSetTimeM.Enabled = true;
                materialSwitchSetting.Enabled = true;
                this.materialButtonAramSet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            }
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //メインラベルに現在時刻
            DateTime now = DateTime.Now;  //現在時刻2(1秒毎に更新)
            materialLabelTimer.Text  = now.ToLongTimeString();


            //アラーム設定中
            if (alarmSetFlag == true)
            {
                //設定時刻の調整
                if (alarmStopFlug == false)//アラームSTOPフラッグがOFF時
                {
                    //アラームモードとタイマーモードの設定
                    if (alarmType == true)//タイマーモード時
                    {
                        //メインラベルに残り時間
                        limitTime = timeCount(limitTime, false);//マイナスカウント
                        materialLabelTimer.Text = limitTime.ToLongTimeString();
                        //サブラベルに現在時刻
                        materialLabelSetTime.Text = "NOW " + now.ToLongTimeString();

                    }
                    else//アラームモード時
                    {
                        //メインラベルに現在時刻
                        materialLabelTimer.Text = now.ToLongTimeString();
                        //サブラベルにセット時間
                        materialLabelSetTime.Text = "SET♪ "
                                 + aramTime.Hour.ToString("00") + ":"
                                 + aramTime.Minute.ToString("00") + ":"
                                 + aramTime.Second.ToString("00");
                    }

                    //設定時刻になった
                    if (aramTime <= now)
                    {
                        ////DELボタンを押す
                        materialButtonAramSet_Click(sender, e);

                        alarmSetFlag = false;//アラームOFF
                        //materialSkinのフォーム 
                        this.TopMost = true;//一度最前表示
                        this.Location = new Point(desktopX, desktopY);//画面中央に表示
                        MaterialSkin.Controls.MaterialMessageBox.Show(this,"時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.TopMost = false;//最前表示解除



                        //スイッチがOFF
                        materialSwitchPageTop.Checked = false;
                        
                       
                    }

                }
                else//アラームSTOPフラッグがON時
                {
                    //ストップ時間をカウント加算
                    aramTime = timeCount(aramTime, true);//プラスカウント

                    if (alarmType == true)//タイマーモード時
                    {
                        //リミット時間ストップ
                        materialLabelTimer.Text = limitTime.ToLongTimeString();
                        //サブラベルに現在時刻
                        materialLabelSetTime.Text = "NOW " + now.ToLongTimeString();

                    }
                    else//アラームモード
                    {
                        //ストップ時間分を加算表示
                        //サブラベルにセット時間
                        materialLabelSetTime.Text = "SET♪ "
                                 + aramTime.Hour.ToString("00") + ":"
                                 + aramTime.Minute.ToString("00") + ":"
                                 + aramTime.Second.ToString("00");
                    }


                }
            }
        }
    

        private void materialComboBoxSetTimeH_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialSliderSetTimeH.Value = TimeValue(materialComboBoxSetTimeH.Text, '時', 23);

        }

        private void materialComboBoxSetTimeM_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialSliderSetTimeM.Value = TimeValue(materialComboBoxSetTimeM.Text, '分', 59);
        }


        private void materialSwitchSetting_CheckedChanged(object sender, EventArgs e)
        {
            //モード切り替え           
            if (materialSwitchSetting.Checked == true)
            {
                //タイマーモード
                alarmType = true;//タイマーモード
                materialSwitchSetting.Text = "TIMER MODE";//タイマー表示

                //リスト初期値を表示
                materialComboBoxSetTimeH.Text = materialComboBoxSetTimeH.Items[0].ToString();
                materialComboBoxSetTimeM.Text = materialComboBoxSetTimeM.Items[0].ToString();
            }
            else
            {
                //アラームモード
                alarmType = false;//アラームモード
                materialSwitchSetting.Text = "ARAM MODE";//アラーム表示

                //現在時刻を表示
                DateTime now = DateTime.Now;
                materialComboBoxSetTimeH.Text = now.Hour.ToString("00") + "時";
                materialComboBoxSetTimeM.Text = now.Minute.ToString("00") + "分";
            }

        }


        private void materialSliderSetTimeH_onValueChanged(object sender, int newValue)
        {
            double n = ((double)materialSliderSetTimeH.Value / 100) * 23;
            materialComboBoxSetTimeH.Text = ((int)n).ToString() + "時";
        }

        private void materialSliderSetTimeM_onValueChanged(object sender, int newValue)
        {
            double n = ((double)materialSliderSetTimeM.Value / 100) * 59;
            materialComboBoxSetTimeM.Text = ((int)n).ToString() + "分";
        }
    }
}
