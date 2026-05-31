using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

namespace WindowsFormsApp2
{
    public static class PdfReaderHelper
    {
        public static string ReadPdf(string path)
        {
            StringBuilder sb = new StringBuilder();
            using (PdfDocument document = PdfDocument.Open(path))
            {
                foreach (var page in document.GetPages())
                {
                    var words = page.GetWords();
                    // Y좌표 기준으로 줄을 나눕니다.
                    var lines = words.GroupBy(w => Math.Round(w.BoundingBox.Bottom, 0)).OrderByDescending(g => g.Key);

                    foreach (var line in lines)
                    {
                        // 💡 X좌표를 기준으로 단어를 정렬합니다.
                        var sortedWords = line.OrderBy(w => w.BoundingBox.Left).ToList();

                        // 표의 각 열(Column) 위치를 추정하여 탭(\t)으로 구분합니다.
                        // 성적표마다 다르겠지만, 보통 X좌표 50, 150, 250, 400 지점에 데이터가 시작됩니다.
                        string formattedLine = "";
                        foreach (var w in sortedWords)
                        {
                            formattedLine += w.Text + "\t"; // 단어 사이에 탭을 넣어 정규식이 구분하기 쉽게 만듭니다.
                        }
                        sb.AppendLine(formattedLine);
                    }
                }
            }
            return sb.ToString();
        }
    }
}