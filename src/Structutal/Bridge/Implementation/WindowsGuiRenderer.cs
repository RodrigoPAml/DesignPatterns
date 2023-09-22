﻿namespace DesignPatterns.Structutal.Bridge.Implementation
{
    // Concrete Implementor classes for different operating systems
    class WindowsGuiRenderer : IGuiRenderer
    {
        public void RenderButton(string text)
        {
            Console.WriteLine($"Windows Button: {text}");
        }

        public void RenderTextBox(string text)
        {
            Console.WriteLine($"Windows TextBox: {text}");
        }
    }
}
