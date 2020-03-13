
List<Student> tempsetudents;



[HttpGet]
public ActionResult Index()
{

  if (Session["mystudents"] == null)
  {
		List<Student> mystudents = new  List<Student>()
		{
			new Student {Id = 108, Name ="Ram"},
			new Student {Id = 1008, Name ="Sita"}
		}
		Session["mystudents"] = mystudents;	  
  }
  else
  {
	  tempsetudents = new List<Student>();
	  tempsetudents = (List<Student>)Session["mystudents"];
	  
	  
  }
  






}