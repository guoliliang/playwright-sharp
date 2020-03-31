using System.Drawing;
using PlaywrightSharp.Input;

namespace PlaywrightSharp
{
    /// <summary>
    /// Options to use when clicking.
    /// </summary>
    public class ClickOptions : WaitForSelectorOptions
    {
        /// <summary>
        /// Time to wait between <c>mousedown</c> and <c>mouseup</c> in milliseconds. Defaults to 0.
        /// </summary>
        public int Delay { get; set; } = 0;

        /// <summary>
        /// Defaults to 1. See https://developer.mozilla.org/en-US/docs/Web/API/UIEvent/detail.
        /// </summary>
        public int ClickCount { get; set; } = 1;

        /// <summary>
        /// The button to use for the click. Defaults to <see cref="MouseButton.Left"/>.
        /// </summary>
        public MouseButton Button { get; set; } = MouseButton.Left;

        /// <summary>
        /// A point to click relative to the top-left corner of element padding box. If not specified, clicks to some visible point of the element.
        /// </summary>
        public Point RelativePoint { get; set; }

        /// <summary>
        /// Modifier keys to press. Ensures that only these modifiers are pressed during the click, and then restores current modifiers back. If not specified, currently pressed modifiers are used.
        /// </summary>
        public Modifier[] Modifiers { get; set; }
    }
}
