using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvmDemo.Business.Managers.Abstract;
using mvvmDemo.Entities;
using mvvmDemo.Presentation.Models;

namespace mvvmDemo.Presentation.ViewModels
{
    public class WorkesViewModels
    {
        private readonly IWorkersManager _workersManager;
        private List<WorkersModel> _items = null;

        public List<WorkersModel> CreateWorkerModel(IEnumerable<Worker> lw)
        {
            List<WorkersModel> lwm = new List<WorkersModel>();
            foreach (Worker w in lw)
            {
                lwm.Add(new WorkersModel(w.id , w.FirstName , w.LastName , w.Position  , w.Phone));
            }
            return lwm;
        }

        public IEnumerable<WorkersModel> Workers
        {
            get {
                if (_items == null)
                {
                    _items = CreateWorkerModel(_workersManager.GetAll());                
                }
                return _items;
            }

        }
        #region Constructor
        public WorkesViewModels(IWorkersManager workersManager)
        {
            this._workersManager = workersManager;
        }
        #endregion Constructor
    }
}
