using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MatchingGame
{
    [Activity(Label = "MatchingGame", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //public List<Card> currentCards { get; set; }
        public List<Card> cardList { get; set; }
        public Card currentCard = null;
        public Card lastCard = null;
        public int fails = 0;
        public int score = 0;
        public int runningScore = 0;
        public Boolean guessed = false;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            cardList = new List<Card>();

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            //var startGameButton = FindViewById<Button>(Resource.Id.startGame);
            var originalButton = FindViewById<Button>(Resource.Id.original);
            var firstButton = FindViewById<Button>(Resource.Id.first);
            var secondButton = FindViewById<Button>(Resource.Id.second);
            var thirdButton = FindViewById<Button>(Resource.Id.third);
            var nextButton = FindViewById<Button>(Resource.Id.nextImage);





            originalButton.Click += delegate {Guess(this, 0);};
            firstButton.Click += delegate { Guess(this, 1); };
            secondButton.Click += delegate { Guess(this, 2); };
            thirdButton.Click += delegate { Guess(this, 3); };
            nextButton.Click += delegate { nextImage(this); };


            //Import In All Cards
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon1, Value = 2 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon2, Value = 2 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon3, Value = 2 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon4, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon5, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon6, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon7, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon8, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon9, Value = 2 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon10, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon11, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon12, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon13, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon14, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon15, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon16, Value = 2 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon17, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon18, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon19, Value = 3 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon21, Value = 3 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon22, Value = 3 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon23, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon24, Value = 2 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon25, Value = 3 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon26, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon27, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon28, Value = 3 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon29, Value = 3 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon20, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon30, Value = 2 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon31, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon32, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon33, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon34, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon35, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon36, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon37, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon38, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon39, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon40, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon41, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon42, Value = 2 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon43, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon44, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon45, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon46, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon48, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon47, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon49, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon50, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon51, Value = 2 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon52, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon53, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon54, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon55, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon56, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon57, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon58, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon59, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon60, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon61, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon62, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon63, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon64, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon65, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon66, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon67, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon68, Value = 2 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon69, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon74, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon75, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon76, Value = 2});
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon77, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon78, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon79, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon80, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon81, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon82, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon83, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon84, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon85, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon86, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon87, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon88, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon89, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon90, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon91, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon92, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon93, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon94, Value = 2 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon95, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon95-1, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon96, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon97, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon98, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon99, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon100, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon101, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon102, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon103, Value = 1 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon104, Value = 0 });
            cardList.Add(new Card { Image = Resource.Drawable.Pokemon105, Value = 1 });

            start(this);

        }


        public void start(MainActivity screen)
        {
            Random random = new Random();
            int randNum = random.Next(0, cardList.Count);
            var layout = screen.FindViewById<LinearLayout>(Resource.Id.appScreen);
            var imageView = screen.FindViewById<ImageView>(Resource.Id.image);
            var card = cardList.Skip(randNum).Take(1).FirstOrDefault();
            imageView.SetImageResource(card.Image);
            currentCard = card;


        }

        public void nextImage(MainActivity screen)
        {
            Random random = new Random();
            
            var textView = screen.FindViewById<TextView>(Resource.Id.textView);
            int randNum = random.Next(0, cardList.Count);
            var imageView = screen.FindViewById<ImageView>(Resource.Id.image);
            var runningScoreView = screen.FindViewById<TextView>(Resource.Id.runningScore);
            var card = cardList.Skip(randNum).Take(1).FirstOrDefault();
            imageView.SetImageResource(card.Image);
            currentCard = card;
            textView.Text = "Please Guess";
            if(!guessed)
            {
                runningScore = 0;
                runningScoreView.Text = "Current Run: " + runningScore;
            }
            guessed = false;

        }

        public void Guess(MainActivity screen, int buttonNum)
        {    
            var textView = screen.FindViewById<TextView>(Resource.Id.textView);
            var scoreView = screen.FindViewById<TextView>(Resource.Id.score);
            var runningScoreView = screen.FindViewById<TextView>(Resource.Id.runningScore);

            guessed = true;
            if (buttonNum == currentCard.Value && lastCard != currentCard)
            {
                lastCard = currentCard;
                fails = 0;
                score += 1;
                runningScore += 1;
                scoreView.Text = "Score: " + score;
                runningScoreView.Text = "Current Run: " + runningScore;
                if(runningScore <= 2)
                {
                    textView.Text = "Correct!";
                }
                else if(runningScore <= 4)
                {
                    textView.Text = "Way to go!";
                }
                else if(runningScore <= 6)
                {
                    textView.Text = "Your on fire!";
                }
                else if (runningScore <= 10)
                {
                    textView.Text = "Amazing!";
                }
                else if (runningScore <= 15)
                {
                    textView.Text = "Pokemon Master!";
                }

            }
            else if(lastCard == currentCard)
            {
                textView.Text = "Click Next Image!";
            }
            else
            {
                fails += 1;
                runningScore = 0;
                runningScoreView.Text = "Current Run: " + runningScore;
                textView.Text = "Incorrect, guess again x" + fails;
            }
        }
    }
}

