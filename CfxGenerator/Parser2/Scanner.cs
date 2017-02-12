using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Parser {

    internal class Scanner {

        string input;
        internal int Position { get; private set; }
        Stack<int> marks = new Stack<int>();
        int maxPosition;

        string CurrentInput { get { return input.Substring(Position); } }
        internal bool Done { get { return Position == input.Length; } }

        internal Match Match { get; private set; }
        internal string Value { get { return Match.Value; } }
        internal string Group01 { get { return Match.Groups[1].Value; } }

        internal Scanner(string input) {
            this.input = input;
            while(Position < input.Length && char.IsWhiteSpace(input[Position])) ++Position;
        }

        internal bool Scan(string pattern, RegexOptions options) {

            Match = Regex.Match(CurrentInput, "^" + pattern, options);
            if(Match.Success) {
                Position += Match.Value.Length;
                if(Position > maxPosition) maxPosition = Position;
                while(Position < input.Length && char.IsWhiteSpace(input[Position])) ++Position;
                return true;
            }
            return false;
        }

        internal void Mark() {
            marks.Push(Position);
        }

        internal void Unmark(bool success) {
            var pos = marks.Pop();
            if(!success) Position = pos;
        }

        internal void ShowPosition() {
            if(marks.Count>0) {
                foreach(var m in marks) {
                    Debug.Print("Mark: " + m);
                    ShowPosition(m);
                }
            }
            Debug.Print("Current: " +  Position);
            ShowPosition(Position);
            Debug.Print("Max: " + maxPosition);
            ShowPosition(maxPosition);
        }

        private void ShowPosition(int pos) {
            var sb1 = new StringBuilder(100);
            var sb2 = new StringBuilder(100);

            var i0 = pos;
            while(i0 >= 0 && input[i0] != '\r' && input[i0] != '\n') --i0;
            if(i0 > 0) ++i0;

            for(int i = i0; i < pos; ++i) {
                sb1.Append(input[i]);
                sb2.Append('-');
            }
            if(pos == input.Length) {
                sb1.Append(' ');
                sb2.Append('^');
            } else {
                sb1.Append(input[pos]);
                sb2.Append('^');
                i0 = pos;
                while(i0 < input.Length - 1 && input[i0 + 1] != '\r' && input[i0 + 1] != '\n') ++i0;
                for(int i = pos + 1; i <= i0; ++i) {
                    sb1.Append(input[i]);
                    sb2.Append('-');
                }
            }
            while(sb1.Length < 50 && ++i0 < input.Length) {
                if(input[i0] == '\n')
                    sb1.Append("¶");
                else
                    sb1.Append(input[i0]);
                sb2.Append("-");

            }
            Debug.Print(sb1.ToString());
            Debug.Print(sb2.ToString());
        }
    }
}
