import { EquityExtended } from "./clientModels";
import { EquityType } from "./models";


export const defaultEquityExtended: EquityExtended = {
    id: 0,
    ticker: "",
    type: EquityType.Stock,
    numberHeld: 0,
    purchasePrice: 0,
    portfolioId: 0,
    currentPrice: 0,
    change: 0
}
