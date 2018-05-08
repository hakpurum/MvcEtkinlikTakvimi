# Mvc Etkinlik Takvimi Yapımı 3

<p>Merhaba arkadaşlar;</p>

<p>Bu makalemde sizlere mvc&#39;de datepicker ile&nbsp;&nbsp;etkinlik takvimi yapımını anlatmaya &ccedil;alışacağım. Daha &ouml;nce jquery ui datepicker ile bir anlatım yapmıştım bu makalemde ise boostrap datepicker ile entegrasyonu sağlıyor olacağız</p>

<p>&Ouml;ncelikle Basic Mvc projesi a&ccedil;ıyoruz.</p>

<p>_Layout&#39;umuza</p>

<p><strong>&nbsp; &nbsp; &lt;link href=&quot;~/Content/bootstrap.min.css&quot; rel=&quot;stylesheet&quot; /&gt;<br />
&nbsp; &nbsp; &lt;link href=&quot;/Content/bootstrap-datetimepicker.css&quot; rel=&quot;stylesheet&quot; /&gt;<br />
&nbsp; &nbsp; &lt;link href=&quot;~/Content/jquery.qtip.min.css&quot; rel=&quot;stylesheet&quot; /&gt;<br />
&nbsp; &nbsp; &lt;link href=&quot;~/Content/Site.css&quot; rel=&quot;stylesheet&quot; /&gt;</strong></p>

<p>css lerini ve</p>

<p><strong>&nbsp; &nbsp; &lt;script src=&quot;~/Scripts/jquery-1.10.2.min.js&quot;&gt;&lt;/script&gt;<br />
&nbsp; &nbsp; &lt;script src=&quot;/scripts/moment.min.js&quot;&gt;&lt;/script&gt;<br />
&nbsp; &nbsp; &lt;script src=&quot;/scripts/bootstrap.min.js&quot;&gt;&lt;/script&gt;<br />
&nbsp; &nbsp; &lt;script src=&quot;~/Scripts/moment-with-locales.min.js&quot;&gt;&lt;/script&gt;<br />
&nbsp; &nbsp; &lt;script src=&quot;/scripts/bootstrap-datetimepicker.js&quot;&gt;&lt;/script&gt;<br />
&nbsp; &nbsp; &lt;script src=&quot;~/Scripts/jquery.qtip.min.js&quot;&gt;&lt;/script&gt;</strong></p>

<p>javascriptlerini reference g&ouml;steriyoruz.</p>

<p><img alt="" src="http://yazilimcigunlugu.com/Upload/Content/101/1.png" style="height:221px; width:636px" /></p>

<p>Daha sonra View &gt; Home &gt; Index sayfamızı a&ccedil;ıyoruz.(B&ouml;yle bir view iniz yoksa Home adında controller ekleyip Index Action ına sağ tıklayıp Add View e tıklayın).</p>

<p>gerekli html kodlarımızı yazıyoruz.<br />
<img alt="" src="http://yazilimcigunlugu.com/Upload/Content/101/2.png" /></p>

<p>Ardında gerekli javascript kodlarımızı yazıyoruz.</p>

<p><img alt="" src="http://yazilimcigunlugu.com/Upload/Content/101/3.png" /></p>

<p>HomeController kısmımız</p>

<p><img alt="" src="http://yazilimcigunlugu.com/Upload/Content/101/4.png" style="height:240px; width:1316px" /></p>

<p>Ben verileri statik olarak doldurdum sizin db den &ccedil;ekip EvenModel ile maplemeniz gerekmektedir.</p>

<p>ve sonu&ccedil; aşağıdaki gibi :)</p>

<p><img alt="" src="http://yazilimcigunlugu.com/Upload/Content/101/screen1.gif" style="height:573px; width:764px" /></p>

<p>Saygılarımla</p>

