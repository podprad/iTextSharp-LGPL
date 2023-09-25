using System;

namespace iTextSharp4.text {
    /// <summary>
    /// Interface for a text element to which other objects can be added.
    /// </summary>
    /// <seealso cref="T:iTextSharp4.text.Phrase"/>
    /// <seealso cref="T:iTextSharp4.text.Paragraph"/>
    /// <seealso cref="T:iTextSharp4.text.Section"/>
    /// <seealso cref="T:iTextSharp4.text.ListItem"/>
    /// <seealso cref="T:iTextSharp4.text.Chapter"/>
    /// <seealso cref="T:iTextSharp4.text.Anchor"/>
    /// <seealso cref="T:iTextSharp4.text.Cell"/>
    public interface ITextElementArray : IElement {
        /// <summary>
        /// Adds an object to the TextElementArray.
        /// </summary>
        /// <param name="o">an object that has to be added</param>
        /// <returns>true if the addition succeeded; false otherwise</returns>
        bool Add(Object o);
    }
}
