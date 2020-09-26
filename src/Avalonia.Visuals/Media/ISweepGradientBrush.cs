namespace Avalonia.Media
{
    /// <summary>
    /// Paints an area with a sweep gradient.
    /// </summary>
    public interface ISweepGradientBrush : IGradientBrush
    {
        /// <summary>
        /// Gets the center point for the gradient.
        /// </summary>
        RelativePoint Center { get; }

        /// <summary>
        /// Gets the starting angle for the gradient in degrees, measured from
        /// the point to the right of the center point.
        /// </summary>
        double Angle { get; }
    }
}
