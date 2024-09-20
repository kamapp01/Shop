using Shop.Domain.OrderOptions;
using Shop.InterfaceAdapter;
using Shop.Domain;
using Shop.Infrastructure.Service;

namespace Shop.Infrastructure;

public class FileShipmentRepos : IShipmentRepos
{
    // path to the "ShipmentFiles" folder where the shipment text files are stored
    private readonly string _directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\TxtFileFolder\ShipmentFiles");
    
    
    public Shipment GetShipment(Order baseOrder)
    {
        Shipment shipment = null;
        FileReadingService readShipmentFiles = new FileReadingService();
            
        string[,] fileData = readShipmentFiles.ReadFiles(_directoryPath);

        for (int i = 0; i < fileData.GetLength(0); i++)
        {
            string ID = fileData[i, 0];
            string description = fileData[i, 1];
            double price = double.Parse(fileData[i, 2]);
                    
            shipment = new Shipment(baseOrder,ID, description, price);
                
        }
        
        return shipment;
    }
}