namespace Fable.UIFabric


open Fable.Core.JsInterop
open Utils


module Styling =
 
  type IFontStyle = { fontFamily: string }
  
  type IThemePalette =
      { themePrimary: string
        themeLighterAlt: string
        themeLighter: string
        themeLight: string
        themeTertiary: string
        themeSecondary: string
        themeDarkAlt: string
        themeDark: string
        themeDarker: string
        neutralLighterAlt: string
        neutralLighter: string
        neutralLight: string
        neutralQuaternaryAlt: string
        neutralQuaternary: string
        neutralTertiaryAlt: string
        neutralTertiary: string
        neutralSecondary: string
        neutralPrimaryAlt: string
        neutralPrimary: string
        neutralDark: string
        black: string
        white: string }

  type ITheme = { defaultFontStyle: IFontStyle
                  palette: IThemePalette }
  
  let createTheme: (obj -> obj) = importMember<obj -> obj> ImportPath
  
  let loadTheme: (obj -> unit) = importMember<obj -> unit> ImportPath

