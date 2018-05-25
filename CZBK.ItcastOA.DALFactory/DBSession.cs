using CZBK.ItcastOA.IDAL;
using CZBK.ItcastOA.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZBK.ItcastOA.Model;

namespace CZBK.ItcastOA.DALFactory
{
    public class DBSession :IDBSession
    {
        /// <summary>
        /// DBSession:工厂类（数据会话层），作用：创建数据操作类的实例，业务层通过DBSession调用相应的数据操作类的实例，这样将业务层与数据层解耦。
        /// </summary>
        OAEntities Db = new OAEntities();
        private IUserInfoDAL _UserInfoDal;
        public IUserInfoDAL UserInfoDal
        {
            get
            {
                if (_UserInfoDal == null)
                {
                    // _UserInfoDal = new IUserInfoDal();//如果要更换数据操作层，这里也要修改。
                    _UserInfoDal = AbstractFactory.CreatsUserInfoDal();
                }
                return _UserInfoDal;
            }
            set
            {
                _UserInfoDal = value;
            }
        }
        /// <summary>
        /// 一个业务中可能涉及到对多张表的操作，那么可以将操作的数据传递到数据层中相应的方法。
        /// </summary>
        /// <returns></returns>
        public bool SaveChange()
        {
            return Db.SaveChanges() > 0;
        }
    }
}