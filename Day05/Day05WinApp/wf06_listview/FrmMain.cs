using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf06_listview
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string currFolder = Environment.CurrentDirectory;   // 현재 프로그램 실행경로 .\bin\debug=
            DirectoryInfo dir = new DirectoryInfo(currFolder);
      
            FileInfo[] Files = dir.GetFiles();      // 현재 디렉토리내 파일 배열

            LsvFiles.BeginUpdate();     // 업데이트완료전까지는 UI 갱신 중지
            LsvFiles.View = View.Details;    // 리스트뷰 화면 자세히 보기로
            CboView.SelectedIndex = 0;  // 뷰보기 콤보박스의 첫번째 값으로 설정

            //ListView에 사용할 아이콘 지정 //윈폼에 코딩으로 넣어줘도됨
            //LsvFiles.LargeImageList = ImgLargeIcon;
            //LsvFiles.SmallImageList = ImgSamllIcon;

            foreach (FileInfo file in Files)
            {
                // 각 파일별로 ListViewItem 객체를 만들어서 하나씩 지정
                ListViewItem lvi = new ListViewItem(file.Name); // 리스트뷰 첫번째 값
                lvi.SubItems.Add(file.LastWriteTime.ToString());

                var ext = Path.GetExtension(file.Name);
                var extName = "";
                switch (ext) {
                    case ".exe":
                        extName = "응용 프로그램";
                        break;
                    case ".config":
                        extName = "Configuration 원본파일";
                        break;
                    case ".pdb":
                        extName = "Program Debug Database";
                        break;
                    default:
                        extName = "기타";
                        break;
                }
                if (ext == ".exe")
                {
                    lvi.ImageIndex = 0;
                }
                else
                {
                    lvi.ImageIndex = 1;
                }

                //lvi.SubItems.Add(file.Attributes.ToString());
                //lvi.SubItems.Add(file.Length.ToString());
                lvi.SubItems.Add(extName); // 유형
                var fileSize = file.Length / 1024;
                lvi.SubItems.Add(string.Format("{0}KB",fileSize));
                // 아이콘은 나중에...
                

                LsvFiles.Items.Add(lvi);
            }

            LsvFiles.EndUpdate();   // 업데이트 끝났으니 UI갱신
        }

        private void CboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var indexVal = CboView.SelectedIndex;
            switch (indexVal)
            {
                case 0: //Details
                    LsvFiles.View = View.Details;
                    break;
                case 1:
                    LsvFiles.View = View.List;
                    break;
                case 2:
                    LsvFiles.View = View.Tile;
                    break;
                case 3:
                    LsvFiles.View = View.SmallIcon;
                    break;
                case 4:
                    LsvFiles.View = View.LargeIcon;
                    break;
                default :
                    LsvFiles.View = View.Details;
                    break;
                   
            }
        }
    }
}

