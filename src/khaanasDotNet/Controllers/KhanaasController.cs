namespace khaanasDotNet.Controllers
{
    using Microsoft.AspNet.Mvc;

    [Route("api")]
    public class KhanaasController : Controller
    {
        public KhanaasController()
        {
        }

        [HttpGet, Route("/spock")]
        public IActionResult GetSpock()
        {
            return GetHtmlResponse("asdf", "/images/spock.jpg");
        }

        private IActionResult GetHtmlResponse(string message, string image)
        {
            var response = new ContentResult();
            response.Content = this.GetHtml(message, image);
            response.ContentType = "text/html";
            return response;
        }

        private string GetHtml(string message, string image)
        {
            return $@"
                <html>
                  <head>
                    <title>Khan As A Service (KHANAAS)</title>
                    <meta charset='utf-8'>
                    <style>
                        span#message {{
                        	font-family:'Helvetica Neue',Helvetica,Arial,sans-serif;
                        	padding-left: .2em;
                        	font-weight: bold;
                        	color: white;
                        	font-size: 10em;
                        	display: inline-block;
                        	white-space: nowrap;
                        }}
                	</style>
                	<script>
                	  (function(i,s,o,g,r,a,m){{i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){{
                	  (i[r].q=i[r].q||[]).push(arguments)}},i[r].l=1*new Date();a=s.createElement(o),
                	  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
                	  }})(window,document,'script','//www.google-analytics.com/analytics.js','ga');
                
                	  ga('create', 'UA-62146225-1', 'khanaas.com');
                	  ga('send', 'pageview');
                
                	</script>
                  </head>
                  <body background='{image}' style='background-size: 100%; margin-top:40px;'>
                        <span id='message'>{message}</span>
                  </body>
                </html>";
        }
    }
}
