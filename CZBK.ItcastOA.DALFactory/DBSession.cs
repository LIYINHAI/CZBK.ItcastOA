using CZBK.ItcastOA.DAL;
using CZBK.ItcastOA.IDAL;
using CZBK.ItcastOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.ItcastOA.DALFactory
{
   public class DBSession
    {
        /// <summary>
        /// DBSession:工厂类（数据会话层），作用：创建数据操作类的实例，业务层通过DBSession调用相应的数据操作类的实例，这样将业务层与数据层解耦。
        /// </summary>
        private IUserInfoDal  _UserInfoDal;
        public IUserInfoDAL UserInfoDal
        {
            get {
                if (_UserInfoDal==null)
                {
                    _UserInfoDal = new UserInfoDal();
                }
                return _UserInfoDal;
            }
            set {
                _UserInfoDal = value;
            }
        }

    }
}
