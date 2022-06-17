namespace HUELLAS_PNT1.Controllers
{
    internal class SqlCommand
    {
        private string gETALL;
        private object con;

        public SqlCommand(string gETALL, object con)
        {
            this.gETALL = gETALL;
            this.con = con;
        }
    }
}