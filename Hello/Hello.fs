namespace Hello

open Xamarin.Forms

type TryFSharpPage() = 
    inherit ContentPage()

    do base.Content <- Label(Text = "Hello, F# Xamarin.Forms",
                             HorizontalOptions = LayoutOptions.Center,
                             VerticalOptions = LayoutOptions.Center,
                             FontSize = 24.0,
                             TextColor = Color.Pink,
                             FontAttributes = FontAttributes.Italic,
                             Rotation = -15.0)

type App() = 
    inherit Application()
    let stack = StackLayout(VerticalOptions = LayoutOptions.Center)
    let label = Label(HorizontalTextAlignment = TextAlignment.Center, Text = "Welcome to F# Xamarin.Forms 2")

    do 
        stack.Children.Add(label)
        base.MainPage <-  TryFSharpPage() 

