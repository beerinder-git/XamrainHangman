using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamrainHangman
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Button AButton = new Button { FontSize = 20, Text = "A" };
        Button BButton = new Button { FontSize = 20, Text = "B" };
        Button CButton = new Button { FontSize = 20, Text = "C" };
        Button DButton = new Button { FontSize = 20, Text = "D" };
        Button EButton = new Button { FontSize = 20, Text = "E" };
        Button FButton = new Button { FontSize = 20, Text = "F" };
        Button GButton = new Button { FontSize = 20, Text = "G" };
        Button HButton = new Button { FontSize = 20, Text = "H" };
        Button IButton = new Button { FontSize = 20, Text = "I" };
        Button JButton = new Button { FontSize = 20, Text = "J" };
        Button KButton = new Button { FontSize = 20, Text = "K" };
        Button LButton = new Button { FontSize = 20, Text = "L" };
        Button MButton = new Button { FontSize = 20, Text = "M" };
        Button NButton = new Button { FontSize = 20, Text = "N" };
        Button OButton = new Button { FontSize = 20, Text = "O" };
        Button PButton = new Button { FontSize = 20, Text = "P" };
        Button QButton = new Button { FontSize = 20, Text = "Q" };
        Button RButton = new Button { FontSize = 20, Text = "R" };
        Button SButton = new Button { FontSize = 20, Text = "S" };
        Button TButton = new Button { FontSize = 20, Text = "T" };
        Button UButton = new Button { FontSize = 20, Text = "U" };
        Button VButton = new Button { FontSize = 20, Text = "V" };
        Button WButton = new Button { FontSize = 20, Text = "W" };
        Button XButton = new Button { FontSize = 20, Text = "X" };
        Button YButton = new Button { FontSize = 20, Text = "Y" };
        Button ZButton = new Button { FontSize = 20, Text = "Z" };
        Button BackButton = new Button { FontSize = 10, Text = "Back" };
        Button EnterButton = new Button { FontSize = 10, Text = "Enter" };

        Image Img = new Image { Source = "hangman.jpg" };

        String Quiz = "HELLO";

        Label[] Letters;

        public MainPage()
        {
            InitializeComponent();

            AButton.Clicked += OnBtnClick;
            BButton.Clicked += OnBtnClick;
            CButton.Clicked += OnBtnClick;
            DButton.Clicked += OnBtnClick;
            EButton.Clicked += OnBtnClick;
            FButton.Clicked += OnBtnClick;
            GButton.Clicked += OnBtnClick;
            HButton.Clicked += OnBtnClick;
            IButton.Clicked += OnBtnClick;
            JButton.Clicked += OnBtnClick;
            KButton.Clicked += OnBtnClick;
            LButton.Clicked += OnBtnClick;
            MButton.Clicked += OnBtnClick;
            NButton.Clicked += OnBtnClick;
            OButton.Clicked += OnBtnClick;
            PButton.Clicked += OnBtnClick;
            QButton.Clicked += OnBtnClick;
            RButton.Clicked += OnBtnClick;
            SButton.Clicked += OnBtnClick;
            TButton.Clicked += OnBtnClick;
            UButton.Clicked += OnBtnClick;
            VButton.Clicked += OnBtnClick;
            WButton.Clicked += OnBtnClick;
            XButton.Clicked += OnBtnClick;
            YButton.Clicked += OnBtnClick;
            ZButton.Clicked += OnBtnClick;
            BackButton.Clicked += OnBtnClick;
            EnterButton.Clicked += OnBtnClick;
            

            Grid keyboardGrid = new Grid();

            //rows
            keyboardGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            keyboardGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            keyboardGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            keyboardGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            //columns
            keyboardGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            keyboardGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            keyboardGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            keyboardGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            keyboardGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            keyboardGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            keyboardGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });



            keyboardGrid.Children.Add(AButton, 0, 0);
            keyboardGrid.Children.Add(BButton, 1, 0);
            keyboardGrid.Children.Add(CButton, 2, 0);
            keyboardGrid.Children.Add(DButton, 3, 0);
            keyboardGrid.Children.Add(EButton, 4, 0);
            keyboardGrid.Children.Add(FButton, 5, 0);
            keyboardGrid.Children.Add(GButton, 6, 0);

            keyboardGrid.Children.Add(HButton, 0, 1);
            keyboardGrid.Children.Add(IButton, 1, 1);
            keyboardGrid.Children.Add(JButton, 2, 1);
            keyboardGrid.Children.Add(KButton, 3, 1);
            keyboardGrid.Children.Add(LButton, 4, 1);
            keyboardGrid.Children.Add(MButton, 5, 1);
            keyboardGrid.Children.Add(NButton, 6, 1);

            keyboardGrid.Children.Add(OButton, 0, 2);
            keyboardGrid.Children.Add(PButton, 1, 2);
            keyboardGrid.Children.Add(QButton, 2, 2);
            keyboardGrid.Children.Add(RButton, 3, 2);
            keyboardGrid.Children.Add(SButton, 4, 2);
            keyboardGrid.Children.Add(TButton, 5, 2);
            keyboardGrid.Children.Add(UButton, 6, 2);

            keyboardGrid.Children.Add(VButton, 0, 3);
            keyboardGrid.Children.Add(WButton, 1, 3);
            keyboardGrid.Children.Add(XButton, 2, 3);
            keyboardGrid.Children.Add(YButton, 3, 3);
            keyboardGrid.Children.Add(ZButton, 4, 3);
            keyboardGrid.Children.Add(BackButton, 5, 3);
            keyboardGrid.Children.Add(EnterButton, 6, 3);


            Grid quizGrid = new Grid();

            quizGrid.VerticalOptions = LayoutOptions.CenterAndExpand;

            quizGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            Letters = new Label[Quiz.Length];

            for (int i = 0; i < Quiz.Length; i++)
            {
                quizGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                Letters[i] = new Label { FontSize = 20, Text = "_" };
                quizGrid.Children.Add(Letters[i], i, 0);
                
            }
            

            Grid userGrid = new Grid();

            userGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            userGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            userGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            userGrid.Children.Add(Img, 0, 0);
            userGrid.Children.Add(quizGrid, 1, 0);


            Grid contentGrid = new Grid();

            contentGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            contentGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            contentGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            contentGrid.Children.Add(userGrid, 0, 0);
            contentGrid.Children.Add(keyboardGrid, 0, 1);

            Content = contentGrid;
        }

        public void OnBtnClick(object sender, EventArgs args)
        {
            (sender as Button).IsEnabled = false;

            List<int> lst = GetPositions(Quiz, (sender as Button).Text);

            //DependencyService.Get<IMessage>().LongAlert(str);

            
            if(Quiz.Contains((sender as Button).Text))
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    Letters[lst[i]].Text = (sender as Button).Text;
                }
            }
            
        }

        public List<int> GetPositions(string source, string searchString)
        {
            List<int> ret = new List<int>();
            int len = searchString.Length;
            int start = -len;
            while (true)
            {
                start = source.IndexOf(searchString, start + len);
                if (start == -1)
                {
                    break;
                }
                else
                {
                    ret.Add(start);
                }
            }
            return ret;
        }
    }
}
