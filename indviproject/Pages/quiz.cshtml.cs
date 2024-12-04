using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace indviproject.Pages
{
    [BindProperties]
    public class quizModel : PageModel
    {
        public string msgScore;

        public string answerMsg1;
        public string answerMsg2;
        public string answerMsg3;
        

        public string MsgColor;
        public string Msg1Color;
        public string Msg2Color;
        public string Msg3Color;
       
        public string question1 { get; set; }
        public string question2 { get; set; }
        public string question3 { get; set; }
        

        public int score;


        public void OnPostSubmit()
        {
            score = 0;

            //question one code
            if (question1 == "7m")
            {
                answerMsg1 = "Correct";
                Msg1Color = "green";
                score = score + 1;

            }
            else if (question1 == "4m")
            {
                answerMsg1 = "Incorrect";
                Msg1Color = "red";
            }

            // else if(question1 == "10m")
            else
            {
                answerMsg1 = "Incorrect";
                Msg1Color = "red";
            }

            // question two code
            if (question2 == "5-7 tones")
            {
                answerMsg2 = "Correct";
                Msg2Color = "green";
                score = score + 1;
            }
            else if (question2 == "5-4 tones")
            {
                answerMsg2 = "Incorrect";
                Msg2Color = "red";

            }
            //else if (question2 == "4-8 tones")
            else
            {
                answerMsg2 = "Incorrect";
                Msg2Color = "red";

            }
            // question three
            if (question3 == "True")
            {
                Msg3Color = "green";
                answerMsg3 = "Correct";
                score = score + 1;


            }
            else
            {
                answerMsg3 = "Incorrect";
                Msg3Color = "red";
            }
            
            if (score == 3)
            {
                msgScore = "Great Job! You got " + score + "/3";
                MsgColor = "green";
            }
            else
            {
                msgScore = "You got " + score + " out of 3 ";

            }
        }
        public void OnGet()
        {
        }
    }
}
