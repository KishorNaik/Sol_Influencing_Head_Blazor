using System;

namespace Sol_Demo.Pages.Demo
{
    public partial class InfluencingHead
    {

        #region Private Property
        private int CurrentCount{get;set;}

        private String TitleText{get;set;}="Default Title";

        private String FaviconPath{get;set;}
        #endregion 

        #region Ui Events
        private void IncrementCount(int increment){
            CurrentCount+=increment;

            if(CurrentCount==0){
                TitleText="Default Title";
                FaviconPath="favicon.ico";
            }
            else
            {
                TitleText=$"Text ({CurrentCount})";
                FaviconPath="favicon_Heart.ico";
            }
            base.StateHasChanged();
        }
        #endregion 
    }
}
