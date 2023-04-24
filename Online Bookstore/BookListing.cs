using System;


public class BookListing : ObservableIF
{
    private int quantity { get; set; }
    private string title { get; set; }
    private string author { get; set; }
    private string genre { get; set; }
    private double price { get; set; }

    public BookListing(string title, string author, string genre, double price, int quantity)
    {
        this.title = title;
        this.author = author;
        this.genre = genre;
        this.quantity = quantity;
        this.price = price;
    }
}
