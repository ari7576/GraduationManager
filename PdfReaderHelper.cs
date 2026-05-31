using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    var words = page.GetWords().ToList();

                    var lines = words
                        .GroupBy(w => Math.Round(w.BoundingBox.Bottom, 0))
                        .OrderByDescending(g => g.Key);

                    foreach (var line in lines)
                    {
                        var w = line.OrderBy(x => x.BoundingBox.Left).ToList();

                        // 1. 이수구분 찾기
                        int typeIdx = -1;
                        for (int i = 0; i < w.Count; i++)
                        {
                            if (IsType(w[i].Text)) { typeIdx = i; break; }
                        }
                        if (typeIdx < 0) continue;

                        // 2. 학수번호 찾기 (이수구분 뒤에서)
                        int codeIdx = -1;
                        for (int i = typeIdx + 1; i < w.Count; i++)
                        {
                            if (Regex.IsMatch(w[i].Text, @"^[A-Za-z]{2,5}\d{4,6}$"))
                            { codeIdx = i; break; }
                        }
                        if (codeIdx < 0) continue;

                        // 3. 분반번호 건너뜀 (학수번호 바로 다음이 숫자/영문 1~2자리면)
                        int nameStart = codeIdx + 1;
                        if (nameStart < w.Count && Regex.IsMatch(w[nameStart].Text, @"^[A-Za-z0-9]{1,2}$"))
                            nameStart++;

                        // 4. 학점+성적 위치 찾기 (뒤에서부터)
                        int creditIdx = -1;
                        for (int i = w.Count - 1; i >= nameStart; i--)
                        {
                            if (Regex.IsMatch(w[i].Text, @"^(0\.5|[123])$"))
                            {
                                if (i + 1 < w.Count && IsGrade(w[i + 1].Text))
                                { creditIdx = i; break; }
                            }
                        }
                        if (creditIdx < 0) continue;

                        string grade = w[creditIdx + 1].Text;
                        if (grade == "F" || grade == "NP" || grade == "W") continue;

                        // 5. 교수명 제거 (학점 바로 앞이 한글 2~4자면)
                        int nameEnd = creditIdx;
                        if (nameEnd > nameStart && Regex.IsMatch(w[nameEnd - 1].Text, @"^[가-힣]{2,4}$"))
                            nameEnd--;

                        // 6. 과목명 조합
                        string name = string.Join("", w.Skip(nameStart).Take(nameEnd - nameStart).Select(x => x.Text)).Trim();
                        if (string.IsNullOrWhiteSpace(name)) name = w[codeIdx].Text;

                        string type = w[typeIdx].Text;
                        string code = w[codeIdx].Text;
                        string credit = w[creditIdx].Text;

                        sb.AppendLine($"{type}\t{code}\t{name}\t{credit}\t{grade}");
                    }
                }
            }
            return sb.ToString();
        }

        private static bool IsType(string s)
        {
            string[] types = {
                "전필","전선","대교","교기","필교","공기","교필","대필",
                "전탐","탐필","탐선","복필","복선","2전필","2전선","트랙전필","트랙전선"
            };
            return types.Contains(s);
        }

        private static bool IsGrade(string s)
        {
            return Regex.IsMatch(s, @"^([A-D][+\-0]?|[AB]0|P|NP|F|W)$");
        }
    }
}