using Shop.InterfaceAdapter;
using Shop.Domain;

namespace Shop.Application;

public class Add_IgnoreShipmentUseCase
{
    private IShipmentRepos _shipmentRepos;
    

    public Add_IgnoreShipmentUseCase(IShipmentRepos shipmentRepos) {
        
        this._shipmentRepos = shipmentRepos;
    }

    
    public Order GetShipment(Order baseOrder)
    {
        return _shipmentRepos.GetShipment(baseOrder); 
    }

}