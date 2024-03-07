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
    using System.Windows.Threading;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer(); // 타이머생성
        int tenthsOfSecondsElapsed;
        int matchesFound;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;
            SetUpGame();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++;
            TimeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
            if (matchesFound == 8)
            {
                timer.Stop();
                TimeTextBlock.Text = TimeTextBlock.Text + " - Play again?";
            }
            //throw new NotImplementedException();
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
                if(textBlock.Name != "TimeTextBlock")
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
            timer.Start();
            tenthsOfSecondsElapsed = 0;
            matchesFound = 0;
        }

        /*
            만약 첫 동물 클릭하면 어떤 TextBlock 클릭 되었는지 저장 하고 동물 감추기
            두번째 동물을 클릭하면 두 동물 일치할 경우 둘 다 감 추고,
            일치 하지 않으면 첫 번째 동물 다시 표시
        */
        TextBlock lastTextBlockClicked;
        bool findingMatch = false; // 플레이어가 첫번째 동물을 찾았는지?

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            // 첫 동물 클릭하면 화면에 보이지 않도록 하고 다른곳에 이모지 우선 저장해둠
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;    
            }
            //짝을 맞췄을 경우, 클릭한 동물 히든 처리
            // findingMatch 초기화하여 다시 동물 클릭할 수 있게한다
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility=Visibility.Hidden;
                findingMatch = false;
            }
            else
            // 짝이 맞지 않는 동물 클릭할 경우 첫번째 동물 다시 보이게 하고 findingMatch 리셋
            {
                lastTextBlockClicked.Visibility=Visibility.Visible;
                findingMatch = false;
            }

        
        }
        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            { //8쌍의 동물 이모지 맞추면 리셋
                SetUpGame();
            }
        }
    }
}
