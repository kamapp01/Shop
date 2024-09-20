using Shop.Domain.OrderOptions;
using Shop.Domain;

namespace Shop.InterfaceAdapter;

    public interface IShipmentRepos
    {
        Shipment GetShipment(Order baseOrder);
    }