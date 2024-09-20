using Shop.InterfaceAdapter;
using Shop.Domain;
namespace Shop.Application;

public class Add_IgnoreGiftWrappingUseCase
{
    
    private IGiftWrappingRepos _giftWrappingRepos;
    

    public Add_IgnoreGiftWrappingUseCase(IGiftWrappingRepos giftWrappingRepos) {
        
        this._giftWrappingRepos = giftWrappingRepos;
    }

    
    public Order GetGiftWrapping(Order baseOrder) {
        
        return _giftWrappingRepos.GetGiftWrapping(baseOrder);
    }

}