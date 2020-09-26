using Avalonia.Controls;
using Avalonia.Media;
using System.Threading.Tasks;
using Xunit;

#if AVALONIA_SKIA
namespace Avalonia.Skia.RenderTests
#else
namespace Avalonia.Direct2D1.RenderTests.Media
#endif
{
    public class SweepGradientBrushTests : TestBase
    {
        public SweepGradientBrushTests() : base(@"Media\SweepGradientBrush")
        {
        }

        [Fact]
        public async Task SweepGradientBrush_RedBlue()
        {
            Decorator target = new Decorator
            {
                Padding = new Thickness(8),
                Width = 200,
                Height = 200,
                Child = new Border
                {
                    Background = new SweepGradientBrush
                    {
                        GradientStops =
                        {
                            new GradientStop { Color = Colors.Red, Offset = 0 },
                            new GradientStop { Color = Colors.Blue, Offset = 1 }
                        }
                    }
                }
            };

            await RenderToFile(target);
            CompareImages();
        }

        [Fact]
        public async Task SweepGradientBrush_RedBlue_Rotation()
        {
            Decorator target = new Decorator
            {
                Padding = new Thickness(8),
                Width = 200,
                Height = 200,
                Child = new Border
                {
                    Background = new SweepGradientBrush
                    {
                        GradientStops =
                        {
                            new GradientStop { Color = Colors.Red, Offset = 0 },
                            new GradientStop { Color = Colors.Blue, Offset = 1 }
                        },
                        Angle = -90
                    }
                }
            };

            await RenderToFile(target);
            CompareImages();
        }

        [Fact]
        public async Task SweepGradientBrush_RedBlue_Center()
        {
            Decorator target = new Decorator
            {
                Padding = new Thickness(8),
                Width = 200,
                Height = 200,
                Child = new Border
                {
                    Background = new SweepGradientBrush
                    {
                        GradientStops =
                        {
                            new GradientStop { Color = Colors.Red, Offset = 0 },
                            new GradientStop { Color = Colors.Blue, Offset = 1 }
                        },
                        Center = new RelativePoint(0.25, 0.25, RelativeUnit.Relative)
                    }
                }
            };

            await RenderToFile(target);
            CompareImages();
        }

        [Fact]
        public async Task SweepGradientBrush_RedBlue_Center_and_Rotation()
        {
            Decorator target = new Decorator
            {
                Padding = new Thickness(8),
                Width = 200,
                Height = 200,
                Child = new Border
                {
                    Background = new SweepGradientBrush
                    {
                        GradientStops =
                        {
                            new GradientStop { Color = Colors.Red, Offset = 0 },
                            new GradientStop { Color = Colors.Blue, Offset = 1 }
                        },
                        Center = new RelativePoint(0.25, 0.25, RelativeUnit.Relative),
                        Angle = -90
                    }
                }
            };

            await RenderToFile(target);
            CompareImages();
        }

        [Fact]
        public async Task SweepGradientBrush_RedBlue_SoftEdge()
        {
            Decorator target = new Decorator
            {
                Padding = new Thickness(8),
                Width = 200,
                Height = 200,
                Child = new Border
                {
                    Background = new SweepGradientBrush
                    {
                        GradientStops =
                        {
                            new GradientStop { Color = Colors.Red, Offset = 0 },
                            new GradientStop { Color = Colors.Blue, Offset = 0.5 },
                            new GradientStop { Color = Colors.Red, Offset = 1 },
                        }
                    }
                }
            };

            await RenderToFile(target);
            CompareImages();
        }

        [Fact]
        public async Task SweepGradientBrush_Umbrella()
        {
            Decorator target = new Decorator
            {
                Padding = new Thickness(8),
                Width = 200,
                Height = 200,
                Child = new Border
                {
                    Background = new SweepGradientBrush
                    {
                        GradientStops =
                        {
                            new GradientStop { Color = Colors.Red, Offset = 0 },
                            new GradientStop { Color = Colors.Yellow, Offset = 0.1667 },
                            new GradientStop { Color = Colors.Lime, Offset = 0.3333 },
                            new GradientStop { Color = Colors.Aqua, Offset = 0.5000 },
                            new GradientStop { Color = Colors.Blue, Offset = 0.6667 },
                            new GradientStop { Color = Colors.Magenta, Offset = 0.8333 },
                            new GradientStop { Color = Colors.Red, Offset = 1 },
                        },
                        Angle = -90
                    }
                }
            };

            await RenderToFile(target);
            CompareImages();
        }
    }
}
