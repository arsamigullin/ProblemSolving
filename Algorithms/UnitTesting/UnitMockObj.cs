using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Attributes;
using Moq;

namespace Algorithms.UnitTesting
{
    [DisplayInfo("Unit Tests", "Testing Mocks", typeof(List<int>))]
    class UnitMockObj
    {
    

        public void Go()
        {
            processEmployee g = new processEmployee();
            g.insertEmployee(new checkEmployee());
        }
        
    }

    public class checkEmployee: IEmpCheck
    {
        public Boolean checkEmp(string g)
        {
            throw new NotImplementedException();
        }
    }

    public interface IEmpCheck
    {
        Boolean checkEmp(string g);
    }

    public class processEmployee
    {
        public Boolean insertEmployee(IEmpCheck objtmp)
        {
            Mock<IEmpCheck> f = new Mock<IEmpCheck>();
            Times times = new Times();
            var tim=  Times.Exactly(1);
            f.Setup(x => x.checkEmp("fsd")).Returns(true);
            var t = f.Object.checkEmp("fsd");
            t = f.Object.checkEmp("fd");
            f.Verify(check => check.checkEmp(""), tim);
            return true;
        }
    }
}
