using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
namespace dxT844058v1.Module.Win.Controllers {



    //public class CustomWinController : ObjectViewController<ListView,Contact> {
    public class CustomWinController : ViewController {
        public CustomWinController() {
             var myAction1 = new SimpleAction(this, "MyWinAction1", null);
              myAction1.Execute += MyAction1_Execute;
            
        }

        private void MyAction1_Execute(object sender, SimpleActionExecuteEventArgs e) {

        }
        //private void MyAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
        //    var os = Application.CreateObjectSpace(typeof(Contact));
        //    var obj = os.CreateObject<Contact>();
        //    var view = Application.CreateDetailView(os, obj);
        //    e.View = view;
        //}
        protected override void OnActivated() {
            base.OnActivated();
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
        }
    }
}
