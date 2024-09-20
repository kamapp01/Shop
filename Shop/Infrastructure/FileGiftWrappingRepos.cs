using Shop.Domain;
using Shop.Domain.OrderOptions;
using Shop.InterfaceAdapter;
using Shop.Infrastructure.Service;

namespace Shop.Infrastructure;

public class FileGiftWrappingRepos : IGiftWrappingRepos
{
    // path to the "GiftWrappingFiles" folder where the gift wrapping text files are stored
    private readonly string _directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\TxtFileFolder\GiftWrappingFiles");

    
    public GiftWrapping GetGiftWrapping(Order baseOrder)
    {

        GiftWrapping giftWrapping = null;
        FileReadingService readGiftWrappingFiles = new FileReadingService();
            
        string[,] fileData = readGiftWrappingFiles.ReadFiles(_directoryPath);

        for (int i = 0; i < fileData.GetLength(0); i++)
        {
            string ID = fileData[i, 0];
            string description = fileData[i, 1];
            double price = double.Parse(fileData[i, 2]);
                    
            giftWrapping = new GiftWrapping(baseOrder,ID, description, price);
                
        }
        
        return giftWrapping;
    }
    
}