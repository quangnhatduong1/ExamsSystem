using ExamsSystem.MyObjects.Question;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.PrintTest
{
    //tạo ra các nội dung câu hỏi của đề thi thuộc bài thi
    class ExamDataPrint : TestPDFGenerate
    {
        private Exams exam;
        public ExamDataPrint(Exams exam)
        {
            this.exam = exam;
        }
        public override void generate(Document pdfDoc)
        {
            pdfDoc.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------") { SpacingBefore = 50 ,Alignment=Element.ALIGN_CENTER});
            Font titleFont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD);
            Font contentFont = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.NORMAL);
            string[] alphaList = { "A", "B", "C", "D" };
            for(int i= 0; i < exam.Questions.Count; i++)
            {
                Questions question = exam.Questions[i];

                Paragraph titleQuestion = createQuestionTitle(i,question.TypeQuestion, question.Title, titleFont, contentFont);
                pdfDoc.Add(titleQuestion);
                for(int j=0; j < question.Answers.Count; j++)
                {
                    string alpha = alphaList[j];
                    string answer = question.Answers[j];
                    Paragraph answerQuestion = createAnswer(alpha, answer, titleFont, contentFont);
                    pdfDoc.Add(answerQuestion);
                }
                
            }
            
        }
        private Paragraph createQuestionTitle(int index,int typeQuestion,string content,Font titleFont, Font contentFont)
        {
           
            Paragraph titleQuestion = new Paragraph() { SpacingBefore = 20 };
            Phrase pharseIndex = new Phrase($"Câu {index + 1}: ", titleFont);
           
            if(typeQuestion == 0)
            {
                content += ". Hãy chọn câu trả lời đúng nhất:";
            }
            else
            {
                content += ". Hãy chọn các câu trả lời đúng:";
            }
            Phrase pharseTitle = new Phrase($"{content}", contentFont);
            titleQuestion.Add(pharseIndex);
            titleQuestion.Add(pharseTitle);
           
            return titleQuestion;
        }
        private Paragraph createAnswer(string alpha, string content, Font titleFont, Font contentFont)
        {
            Paragraph answerQuestion = new Paragraph() { SpacingBefore = 5 };
            Phrase phraseAlpha = new Phrase($"   {alpha}. ", titleFont);
            Phrase phraseAnswer = new Phrase($"{content} ", contentFont);
            answerQuestion.Add(phraseAlpha);
            answerQuestion.Add(phraseAnswer);
            return answerQuestion;
        }


    }
}
