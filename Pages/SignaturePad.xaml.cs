using SkiaSharp;
using SkiaSharp.Views.Maui;
using SkiaSharp.Views.Maui.Controls;

namespace Atrax.Pages;

public partial class SignaturePad : ContentPage
{
    private List<SKPoint?> points = new();

    public SignaturePad()
    {
        InitializeComponent();
    }

    private void OnCanvasViewTouch(object sender, SKTouchEventArgs e)
    {
        if (e.ActionType == SKTouchAction.Pressed ||
            e.ActionType == SKTouchAction.Moved)
        {
            if (e.InContact)
            {
                points.Add(e.Location);
                canvasView.InvalidateSurface();
            }
        }
        else if (e.ActionType == SKTouchAction.Released || 
            e.ActionType == SKTouchAction.Cancelled)
        {
            points.Add(null); 
        }


        e.Handled = true;
    }

    private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
    {
        var canvas = e.Surface.Canvas;
        canvas.Clear(new SKColor(0xF2, 0xF2, 0xF2));

        var paint = new SKPaint
        {
            Color = SKColors.Black,
            StrokeWidth = 2,
            IsAntialias = true,
            Style = SKPaintStyle.Stroke
        };
        SKPath path = new SKPath();

        SKPoint? previous = null;

        foreach (var point in points)
        {
            if (point == null)
            {
                previous = null;
                continue;
            }

            if (previous == null)
            {
                path.MoveTo(point.Value);
            }
            else
            {
                path.LineTo(point.Value);
            }

            previous = point;
        }

        canvas.DrawPath(path, paint);
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        points.Clear();
        canvasView.InvalidateSurface();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (points.Count == 0)
        {
            await DisplayAlert("Error", "Please draw your signature.", "OK");
            return;
        }

        await DisplayAlert("Success", $"Signature saved for {SignedByEntry.Text}", "OK");
        
    }

    private async void OnBackTapped(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void OnClearTapped(object sender, EventArgs e)
    {
        OnClearClicked(sender, e); 
    }

}
