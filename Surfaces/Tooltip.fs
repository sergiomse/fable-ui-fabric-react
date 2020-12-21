namespace Fable.UIFabric

open Fable.React
open Fable.React.Props
open Utils

type DirectionalHint =
    | topLeftEdge = 0
    | topCenter = 1
    | topRightEdge = 2
    | topAutoEdge = 3
    | bottomLeftEdge = 4
    | bottomCenter = 5
    | bottomRightEdge = 6
    | bottomAutoEdge = 7
    | leftTopEdge = 8
    | leftCenter = 9
    | leftBottomEdge = 10
    | rightTopEdge = 11
    | rightCenter = 12
    | rightBottomEdge = 13
        
module Tooltip =
    type ITooltipHost =
        | Content of string
        | DirectionalHint of DirectionalHint
        
        interface IHTMLProp
        static member p (xs: ITooltipHost list) = kvl xs
    
    let tooltipHost props = ofImport "TooltipHost" "office-ui-fabric-react/lib/Tooltip" (ITooltipHost.p props)
    

