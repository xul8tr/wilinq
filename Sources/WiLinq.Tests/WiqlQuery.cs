using System.Linq;
using NFluent;
using NUnit.Framework;
using WiLinq.LinqProvider;
using WiLinq.LinqProvider.Extensions;

namespace WiLinq.Tests
{
    [TestFixture]
    public class WorkItemLinqQueryShould : TestFixtureBase
    {
        [Test]
       
        public void Return_Only_One_Element_With_The_Right_Id()
        {
            //all workitems;
            var q = from workitem in Client.WorkItemSet()
                    where workitem.Id == 3
                    select workitem;

            // ReSharper disable once UnusedVariable
            var result = q.ToList();

            Check.That(result).HasSize(1);
            Check.That(result[0].Id).Equals(3);
        }
        [Test]
      
        public void Return_Only_One_Element_Of_Type_Bug_With_The_Right_Id()
        {
            //all workitems;
            var q = from workitem in Client.SetOf<Bug>(Project)
                    where workitem.Id == 174
                    select workitem;

            // ReSharper disable once UnusedVariable
            var result = q.ToList();

            Check.That(result).HasSize(1);
            Check.That(result[0].Id).Equals(174);           
        }

        [Test]
        public void Return_No_Element_Of_Type_PBI_With_The_Id_Of_Bug()
        {
            //all workitems;
            var q = from workitem in Client.SetOf<Bug>(Project)
                where workitem.Id == 174
                select workitem;

            // ReSharper disable once UnusedVariable
            var result = q.ToList();

            Check.That(result).IsEmpty();
        }

#if false
        [Test]
        public void ProjectQueryAllWorkitems()
        {
            //all workitems;
            var projectWiQuery = from workitem in Project.WorkItemSet()
                                 select workitem;

            // ReSharper disable once UnusedVariable
            var result = projectWiQuery.ToList();
        }

        [Test]
        public void ProjectQuery()
        {
            //all workitems;
            var projectWiQuery = from workitem in Project.WorkItemSet()
                                 where workitem.Id == 3
                                 select workitem;

            // ReSharper disable once UnusedVariable
            var result = projectWiQuery.ToList();
        }

        [Test]
        public void Query_With_Field_Value_As_A_WI_Field()
        {
            var projectWiQuery = from workitem in Project.WorkItemSet()
                                 where workitem.CreatedBy == workitem.ChangedBy
                                 select workitem;
            // ReSharper disable once UnusedVariable
            var result = projectWiQuery.ToList();
        }

        [Test]
        public void Query_With_Field_Value_As_AWI_Field_With_Field_Method()
        {
            var projectWiQuery = from workitem in Project.WorkItemSet()
                                 where workitem.CreatedBy == workitem.Field<string>("System.AssignedTo")
                                 select workitem;
            // ReSharper disable once UnusedVariable
            var result = projectWiQuery.ToList();
        }

        [Test]
        public void Query_With_Field_Method()
        {
            var projectWiQuery = from workitem in Project.WorkItemSet()
                                 where workitem.Title.Contains("Build")
                                 && workitem.Field<string>("System.AssignedTo") == "John Doe"
                                 select workitem;
            // ReSharper disable once UnusedVariable
            var result = projectWiQuery.ToList();
        }


        [Test]
        public void Query_With_QueryConstant_Me()
        {
            var projectWiQuery = from workitem in Project.WorkItemSet()
                                 where workitem.CreatedBy == QueryConstant.Me
                                 select workitem;
            // ReSharper disable once UnusedVariable
            var result = projectWiQuery.ToList();
        }


#endif
    }

    [WorkItemType("Bug")]
    public class Bug : WorkItemBase
    {
        public Bug()
        {

        }
    }

    [WorkItemType("Product Backlog Item")]
    public class PBI : WorkItemBase
    {
        public PBI()
        {

        }
    }
}
