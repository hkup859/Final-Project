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
        public List<Card> currentCards { get; set; }
        public Boolean gameGoing = false;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            currentCards = new List<Card>();

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            var startGameButton = FindViewById<Button>(Resource.Id.startGame);
            var button1 = FindViewById<Button>(Resource.Id.button1);
            var imageButton1 = FindViewById<ImageButton>(Resource.Id.card1);
            var imageButton2 = FindViewById<ImageButton>(Resource.Id.card2);
            var imageButton3 = FindViewById<ImageButton>(Resource.Id.card3);
            var imageButton4 = FindViewById<ImageButton>(Resource.Id.card4);
            var imageButton5 = FindViewById<ImageButton>(Resource.Id.card5);
            var imageButton6 = FindViewById<ImageButton>(Resource.Id.card6);
            var imageButton7 = FindViewById<ImageButton>(Resource.Id.card7);
            var imageButton8 = FindViewById<ImageButton>(Resource.Id.card8);
            var imageButton9 = FindViewById<ImageButton>(Resource.Id.card9);
            var imageButton10 = FindViewById<ImageButton>(Resource.Id.card10);
            var imageButton11 = FindViewById<ImageButton>(Resource.Id.card11);
            var imageButton12 = FindViewById<ImageButton>(Resource.Id.card12);
            var imageButton13 = FindViewById<ImageButton>(Resource.Id.card13);
            var imageButton14 = FindViewById<ImageButton>(Resource.Id.card14);
            var imageButton15 = FindViewById<ImageButton>(Resource.Id.card15);
            var imageButton16 = FindViewById<ImageButton>(Resource.Id.card16);
            var imageButton17 = FindViewById<ImageButton>(Resource.Id.card17);
            var imageButton18 = FindViewById<ImageButton>(Resource.Id.card18);
            var imageButton19 = FindViewById<ImageButton>(Resource.Id.card19);
            var imageButton20 = FindViewById<ImageButton>(Resource.Id.card20);
            var imageButton21 = FindViewById<ImageButton>(Resource.Id.card21);
            var imageButton22 = FindViewById<ImageButton>(Resource.Id.card22);
            var imageButton23 = FindViewById<ImageButton>(Resource.Id.card23);
            var imageButton24 = FindViewById<ImageButton>(Resource.Id.card24);
            


            startGameButton.Click += delegate {StartGame(this);};
            button1.Click += delegate {viewChange(this);};
            imageButton1.Click += delegate {cardClicked(imageButton1, 1);};
            imageButton2.Click += delegate { cardClicked(imageButton2, 2); };
            imageButton3.Click += delegate { cardClicked(imageButton3, 3); };
            imageButton4.Click += delegate { cardClicked(imageButton4, 4); };
            imageButton5.Click += delegate { cardClicked(imageButton5, 5); };
            imageButton6.Click += delegate { cardClicked(imageButton6, 6); };
            imageButton7.Click += delegate { cardClicked(imageButton7, 7); };
            imageButton8.Click += delegate { cardClicked(imageButton8, 8); };
            imageButton9.Click += delegate { cardClicked(imageButton9, 9); };
            imageButton10.Click += delegate { cardClicked(imageButton10, 10); };
            imageButton11.Click += delegate { cardClicked(imageButton11, 11); };
            imageButton12.Click += delegate { cardClicked(imageButton12, 12); };
            imageButton13.Click += delegate { cardClicked(imageButton13, 13); };
            imageButton14.Click += delegate { cardClicked(imageButton14, 14); };
            imageButton15.Click += delegate { cardClicked(imageButton15, 15); };
            imageButton16.Click += delegate { cardClicked(imageButton16, 16); };
            imageButton17.Click += delegate { cardClicked(imageButton17, 17); };
            imageButton18.Click += delegate { cardClicked(imageButton18, 18); };
            imageButton19.Click += delegate { cardClicked(imageButton19, 19); };
            imageButton20.Click += delegate { cardClicked(imageButton20, 20); };
            imageButton21.Click += delegate { cardClicked(imageButton21, 21); };
            imageButton22.Click += delegate { cardClicked(imageButton22, 22); };
            imageButton23.Click += delegate { cardClicked(imageButton23, 23); };
            imageButton24.Click += delegate { cardClicked(imageButton24, 24); };
        }



        public void StartGame(MainActivity gameBoard)
        {
            var gameMap = gameBoard.FindViewById<GridLayout>(Resource.Id.gameMap);
            var homeMenu = gameBoard.FindViewById<LinearLayout>(Resource.Id.homeMenu);
            
            gameMap.Visibility = Android.Views.ViewStates.Visible;
            homeMenu.Visibility = Android.Views.ViewStates.Gone;
            

            //Import In All Cards
            List<Card> cardList = new List<Card>();
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon1,  BackImage = Resource.Drawable.black, Visible = 0, Value = 1});
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon2,  BackImage = Resource.Drawable.black, Visible = 0, Value = 2 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon3,  BackImage = Resource.Drawable.black, Visible = 0, Value = 3 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon4,  BackImage = Resource.Drawable.black, Visible = 0, Value = 4 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon5,  BackImage = Resource.Drawable.black, Visible = 0, Value = 5 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon6,  BackImage = Resource.Drawable.black, Visible = 0, Value = 6 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon7,  BackImage = Resource.Drawable.black, Visible = 0, Value = 7 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon8,  BackImage = Resource.Drawable.black, Visible = 0, Value = 8 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon9,  BackImage = Resource.Drawable.black, Visible = 0, Value = 9 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon10,  BackImage = Resource.Drawable.black, Visible = 0, Value = 10 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon11,  BackImage = Resource.Drawable.black, Visible = 0, Value = 11 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon12,  BackImage = Resource.Drawable.black, Visible = 0, Value = 12 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon13,  BackImage = Resource.Drawable.black, Visible = 0, Value = 13 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon14,  BackImage = Resource.Drawable.black, Visible = 0, Value = 14 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon15,  BackImage = Resource.Drawable.black, Visible = 0, Value = 15 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon16,  BackImage = Resource.Drawable.black, Visible = 0, Value = 16 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon17,  BackImage = Resource.Drawable.black, Visible = 0, Value = 17 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon18,  BackImage = Resource.Drawable.black, Visible = 0, Value = 18 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon19,  BackImage = Resource.Drawable.black, Visible = 0, Value = 19 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon21,  BackImage = Resource.Drawable.black, Visible = 0, Value = 20 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon22,  BackImage = Resource.Drawable.black, Visible = 0, Value = 21 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon23,  BackImage = Resource.Drawable.black, Visible = 0, Value = 22 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon24,  BackImage = Resource.Drawable.black, Visible = 0, Value = 23 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon25,  BackImage = Resource.Drawable.black, Visible = 0, Value = 24 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon26,  BackImage = Resource.Drawable.black, Visible = 0, Value = 25 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon27,  BackImage = Resource.Drawable.black, Visible = 0, Value = 26 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon28,  BackImage = Resource.Drawable.black, Visible = 0, Value = 27 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon29,  BackImage = Resource.Drawable.black, Visible = 0, Value = 28 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon20,  BackImage = Resource.Drawable.black, Visible = 0, Value = 29 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon30,  BackImage = Resource.Drawable.black, Visible = 0, Value = 30 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon31,  BackImage = Resource.Drawable.black, Visible = 0, Value = 31 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon32,  BackImage = Resource.Drawable.black, Visible = 0, Value = 32 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon33,  BackImage = Resource.Drawable.black, Visible = 0, Value = 33 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon34,  BackImage = Resource.Drawable.black, Visible = 0, Value = 34 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon35,  BackImage = Resource.Drawable.black, Visible = 0, Value = 35 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon36,  BackImage = Resource.Drawable.black, Visible = 0, Value = 36 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon37,  BackImage = Resource.Drawable.black, Visible = 0, Value = 37 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon38,  BackImage = Resource.Drawable.black, Visible = 0, Value = 38 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon39,  BackImage = Resource.Drawable.black, Visible = 0, Value = 39 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon40,  BackImage = Resource.Drawable.black, Visible = 0, Value = 40 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon41,  BackImage = Resource.Drawable.black, Visible = 0, Value = 41 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon42,  BackImage = Resource.Drawable.black, Visible = 0, Value = 42 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon43,  BackImage = Resource.Drawable.black, Visible = 0, Value = 43 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon44,  BackImage = Resource.Drawable.black, Visible = 0, Value = 44 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon45,  BackImage = Resource.Drawable.black, Visible = 0, Value = 45 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon46,  BackImage = Resource.Drawable.black, Visible = 0, Value = 46 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon48,  BackImage = Resource.Drawable.black, Visible = 0, Value = 47 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon47,  BackImage = Resource.Drawable.black, Visible = 0, Value = 48 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon49,  BackImage = Resource.Drawable.black, Visible = 0, Value = 49 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon50,  BackImage = Resource.Drawable.black, Visible = 0, Value = 50 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon51,  BackImage = Resource.Drawable.black, Visible = 0, Value = 51 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon52,  BackImage = Resource.Drawable.black, Visible = 0, Value = 52 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon53,  BackImage = Resource.Drawable.black, Visible = 0, Value = 53 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon54,  BackImage = Resource.Drawable.black, Visible = 0, Value = 54 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon55,  BackImage = Resource.Drawable.black, Visible = 0, Value = 55 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon56,  BackImage = Resource.Drawable.black, Visible = 0, Value = 56 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon57,  BackImage = Resource.Drawable.black, Visible = 0, Value = 57 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon58,  BackImage = Resource.Drawable.black, Visible = 0, Value = 58 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon59,  BackImage = Resource.Drawable.black, Visible = 0, Value = 59 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon60,  BackImage = Resource.Drawable.black, Visible = 0, Value = 60 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon61,  BackImage = Resource.Drawable.black, Visible = 0, Value = 61 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon62,  BackImage = Resource.Drawable.black, Visible = 0, Value = 62 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon63,  BackImage = Resource.Drawable.black, Visible = 0, Value = 63 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon64,  BackImage = Resource.Drawable.black, Visible = 0, Value = 64 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon65,  BackImage = Resource.Drawable.black, Visible = 0, Value = 65 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon66,  BackImage = Resource.Drawable.black, Visible = 0, Value = 66 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon67,  BackImage = Resource.Drawable.black, Visible = 0, Value = 67 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon68,  BackImage = Resource.Drawable.black, Visible = 0, Value = 68 });
            cardList.Add(new Card { FrontImage = Resource.Drawable.Pokemon69,  BackImage = Resource.Drawable.black, Visible = 0, Value = 69 });

            Random random = new Random();
            var layout = gameBoard.FindViewById<GridLayout>(Resource.Id.gameMap);

            //var test = (ImageButton)layout.GetChildAt(0);
            List<Card> cardDisplayList = new List<Card>();
            //currentCards = new List<Card>();

            for (int i = 0; i < layout.ChildCount/2; i++)
            {
                int randNum = random.Next(0, cardList.Count);
                Card card = cardList.Skip(randNum).Take(1).FirstOrDefault();
                cardDisplayList.Add(card);
                cardDisplayList.Add(card);
            }

            for (int i = 1; i < layout.ChildCount-1; i++)
            {
                int randNum = random.Next(0, cardDisplayList.Count);
                Card card = cardDisplayList.Skip(randNum).Take(1).FirstOrDefault();
                var imageButton = ((ImageButton)layout.GetChildAt(i));
                
                if(card == null)
                    card = cardList.Skip((int)((i/2.0)+0.5)).Take(1).FirstOrDefault();

                imageButton.SetImageResource(card.FrontImage);
                gameBoard.currentCards.Add(card);
                cardDisplayList.RemoveAt(randNum);
            }

            System.Threading.Thread.Sleep(3000);
            Toast toast = Toast.MakeText(this, "Testing Message", ToastLength.Short);
            toast.Show();



            //System.Threading.Thread.Sleep(3000);
        }

        public void viewChange(MainActivity gameBoard)
        {

///*            
            var layout = gameBoard.FindViewById<GridLayout>(Resource.Id.gameMap);
            for (int i = 1; i < layout.ChildCount - 2; i++)
            {
                //int randNum = random.Next(0, cardDisplayList.Count);
                //Card card = cardDisplayList.Skip(i).Take(1).FirstOrDefault();
                Card card = currentCards.Skip(i).Take(1).FirstOrDefault();
                var imageButton = ((ImageButton)layout.GetChildAt(i));
                //
                //if (card == null)
                //    card = cardList.Skip((int)((i / 2.0) + 0.5)).Take(1).FirstOrDefault();

                imageButton.SetImageResource(card.BackImage);
                //cardDisplayList.RemoveAt(i);
            }
            
            //*/


            /*            var layout = gameBoard.FindViewById<GridLayout>(Resource.Id.gameMap);
                        ImageButton visible1 = null;
                        ImageButton visible2 = null;
                        Card defaultCard = currentCards.Skip(1).Take(1).FirstOrDefault();
                        for (int i = 1; i < layout.ChildCount - 2; i++)
                        { 
                            Card card = currentCards.Skip(i).Take(1).FirstOrDefault();           
                            var imageButton = ((ImageButton)layout.GetChildAt(i));

                            if (gameGoing == false)
                            {
                                imageButton.SetImageResource(card.BackImage);
                            }
                            else
                            {
                                //If imageButton is not backImage
                                //If(imageButton.SetImageResource = "test")
                                if(card.Visible == 1)
                                {
                                    if(visible1 == null)
                                    {
                                        visible1 = imageButton;
                                    }
                                    else
                                    {
                                        visible2 = imageButton;
                                    }
                                }
                            }
                        } //End For Loop

                        if(visible1 != null && visible2 != null)
                        {
                            //Wait(3 Seconds), then reset.
                            System.Threading.Thread.Sleep(3000);
                            visible1.SetImageResource(defaultCard.BackImage);
                            visible2.SetImageResource(defaultCard.BackImage);
                            visible1 = null;
                            visible2 = null;
                        }

                        gameGoing = true;

             */
        }

        public void cardClicked(ImageButton button, int cardNum)
        {
            //Physically Show card
            Card card = currentCards.Skip(cardNum).Take(1).FirstOrDefault();
            button.SetImageResource(card.FrontImage);
            //Set card's visible to 1
            card.Visible = 1;
           
        }


    }
}

