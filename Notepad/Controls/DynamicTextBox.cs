using System;
using System.Text;
using System.Windows.Forms;
using Notepad.Extensions;

namespace Notepad.Controls
{
    public class DynamicTextBox : RichTextBox
    {
        public DynamicTextBox()
        {
            KeyPress += KeyPressed;
            KeyDown += KeyIsDown;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
                e.Handled = true;
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            var index = SelectionStart;
            var length = SelectionLength;
            var builder = new StringBuilder(Text);
            var selectedText = Text.Substring(index, length);

            if (e.KeyChar == '\t')
            {
                if (!selectedText.Contains("\n"))
                {
                    if (ModifierKeys != Keys.Shift)
                    {
                        builder.Insert(index, "    ");

                        index += 4;
                    }
                    else
                    {
                        if (index > 3)
                        {
                            if (Text[index - 1] == ' ' && Text[index - 2] == ' ' &&
                                Text[index - 3] == ' ' && Text[index - 4] == ' ')
                            {
                                builder.Remove(index - 4, 4);
                                index -= 4;
                            }
                        }
                    }
                }
                else
                {
                    if (ModifierKeys != Keys.Shift)
                    {
                        builder.Replace("\n", "\n    ", index, length);
                    }
                    else
                    {
                        builder.Replace("\n    ", "\n", index, length);
                    }
                }
            }
            else if (e.KeyChar == '\r')
            {
                var currentLine = Lines[GetLineFromCharIndex(SelectionStart) - 1];
                var spaces = currentLine.LeadingSpaces();

                builder.Append(spaces);
                index += spaces.Length;
            }
            else if (e.KeyChar == '\b')
            {
                var currentLine = "";
                try
                {
                    currentLine = Lines[GetLineFromCharIndex(SelectionStart)];
                }
                catch (IndexOutOfRangeException)
                {
                    return;
                }

                if (length < 1 && currentLine.Length < 1)
                {
                    builder.Remove(index - 1, 1);
                    index -= 1;
                }
                else
                {
                    if (!currentLine.OnlyContains(' '))
                    {
                        if (index == Text.Length || length < 1)
                        {
                            builder.Remove(index - 1, 1);
                            index -= 1;
                        }
                        else
                        {
                            builder.Remove(index, length);
                        }
                    }
                    else
                    {
                        var len = currentLine.Length;
                        if (len > 4)
                        {
                            var toRemove = 1;

                            while ((len - toRemove) % 4 != 0)
                            {
                                toRemove++;
                            }

                            builder.Remove(index - toRemove, toRemove);
                            index -= toRemove;
                        }
                        else
                        {
                            builder.Remove(index - len, len);
                            index -= len;
                        }
                    }
                }
            }
            else
            {
                return;
            }

            Text = builder.ToString();
            Select(index, 0);

            e.Handled = true;
        }
    }
}