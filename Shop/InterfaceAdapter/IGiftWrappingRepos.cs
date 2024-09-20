using Shop.Domain.OrderOptions;
using Shop.Domain;

namespace Shop.InterfaceAdapter;

    public interface IGiftWrappingRepos
    {
        GiftWrapping GetGiftWrapping(Order baseOrder);
    }