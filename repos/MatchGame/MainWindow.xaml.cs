using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
           // throw new NotImplementedException();메서드를 구현하지 않을까봐 VS에서 만들어둔 코드
            // 디버깅 중지 -> Shift + F5

            // 8쌍의 이모지가 든 목록을 생성
            List<string> animalEmoji = new List<string>()
            {
                "🐰","🐰",
                "🐼","🐼",
                "🐥","🐥",
                "🐺","🐺",
                "🐻","🐻",
                "🐯","🐯",
                "🐱","🐱",
                "🐨","🐨",

            };
            // 랜덤생성자
            Random rand = new Random();
            //mainGrid에 포함된 모든 TextBlock을 찾아 명령문 실행
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) 
            {
                if(textBlock.Name != "timeTextBlock")
                {
                    textBlock.Visibility = Visibility.Visible;
                    //0부터 이모지 목록에 남은 이모지 개수중 임의의 숫자를 택해 index 이름을 붙인다
                    int index = rand.Next(animalEmoji.Count);
                    //index에 붙은 임의의 숫자를 사용해 목록에서 랜덤 이모지를 꺼낸다
                    string nextemoji = animalEmoji[index];
                    // textBlock의 텍스트 (현재는 "?")를 이모지로 변경한다
                    textBlock.Text = nextemoji;
                    // 목록에서 이모지 제거
                    animalEmoji.RemoveAt(index);
                }
            }
        }
    }
}
