﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebRestClient.index1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title>二手书交易平台</title>
	<link rel="stylesheet" type="text/css" href="css/index.css">
</head>
<body>

	<!-- 导航 -->
	<header class="navbar">
		<div class="nav-info">
			<%--<a id="username" href="personalInfo.aspx" class="username">xlf</a>--%>
			<a href="personalInfo.aspx" class="bookshelf">||&nbsp;&nbsp;&nbsp;个人信息</a>
			<a href="Login.aspx" class="logout">[ 退 出 ]</a>
		</div> <!-- nav-info -->
		<form runat="server" class="nav-search">
			<a href="index.aspx"><img class="logo" src="img/logo.jpg"></a>
			<div class="search-form">
				<a href="#" class="search-logo">| &nbsp;<img src="img/search.png"></a>
				<input type="search" class="searchIn" placeholder="搜图书...">
				<button class="searchBtn">搜索</button>
			</div>
		</form><!--  nav-search -->
		<ul class="menu">
			<li><a class="active" href="index.aspx">首页</a></li>
			<li><a href="cart.html">购物车</a></li>
			<li><a href="releaseBook.html">发布图书</a></li>
			<li><a href="myOder.html">我的订单</a></li>
		</ul>
	</header>

	<!-- 轮播 -->
	<div class="carousel">
		<div class="book-guide">
			<h4>图书导航</h4>
			<ul class="book-class">
				<li><a href="#article" title="article">小说 / 文学 </a></li>
				<li><a href="#technology" title="technology">工程 / 计算机</a></li>
				<li><a href="#">历史 / 地理</a></li>
				<li><a href="#">政治 / 法律 </a></li>					
				<li><a href="#">哲学 / 心理 </a></li>
				<li><a href="#">经济 / 社科 </a></li>
				<li><a href="#">生活 / 体育</a></li>
				<li><a href="#"> 教辅 / 考试</a></li>					
				
				<li><a href="#">科学 / 卫生</a></li>							
			</ul>
		</div><!-- book-guide -->
		<div class="slider">
			<div class="slider-img">
				<ul class="slider-img-ul">
					<li><img src="img/carousel/5.jpg"></li>
					<li><img src="img/carousel/1.jpg"></li>
					<li><img src="img/carousel/2.jpg"></li>
					<li><img src="img/carousel/3.jpg"></li>
					<li><img src="img/carousel/4.jpg"></li>
					<li><img src="img/carousel/5.jpg"></li>
					<li><img src="img/carousel/1.jpg"></li>
				</ul>
			</div>
		</div><!-- 	slider -->
	</div><!-- carousel -->

	<!-- 图书分类 -->
	<div id="container">
		<div class="book-part" id="article">
			<h3 class="book-title"><a href="#">| 小说 / 文学 </a></h3>
			<a class="more" href="#"> > > 更多</a>
			<ul class="book-lists">
				<li class="book-list">
					<a href="#" class="book-pic">
						<img src="img/book-list/article/1.jpg">
					</a>
					<a href="#" class="book-info">
						<h5 class="book-name">三国志</h5>
						<span class="book-detail">陈寿 著 / 南海出版公司 / 2008-09 / 平装</span>
					</a>
					<span class="book-price">￥22.8
						<a href="#" class="book-buy">立即下单</a>
					</span>
				</li>

				<li class="book-list">
					<a href="#" class="book-pic">
						<img src="img/book-list/article/2.jpg">
					</a>
					<a href="#" class="book-info">
						<h5 class="book-name">东京梦华录</h5>
						<span class="book-detail">孟元老 著 / 湖北图书出版社 / 2011-10 / 平装</span>
					</a>
					<span class="book-price">￥27.3
						<a href="#" class="book-buy">立即下单</a>
					</span>
				</li>				

				<li class="book-list">
					<a href="#" class="book-pic">
						<img src="img/book-list/article/3.jpg">
					</a>
					<a href="#" class="book-info">
						<h5 class="book-name">红字</h5>
						<span class="book-detail">纳撒尼尔 霍桑 著 / 译林出版社 / 2006-06 / 平装</span>
					</a>
					<span class="book-price">￥22.4
						<a href="#" class="book-buy">立即下单</a>
					</span>
				</li>				

				<li class="book-list">
					<a href="#" class="book-pic">
						<img src="img/book-list/article/4.jpg">
					</a>
					<a href="#" class="book-info">
						<h5 class="book-name">瓦尔登湖</h5>
						<span class="book-detail">亨利 戴维 梭罗 作者 / 上海文艺出版社 / 2004-05 / 平装</span>
					</a>
					<span class="book-price">￥20.3
						<a href="#" class="book-buy">立即下单</a>
					</span>
				</li>				

				<li class="book-list">
					<a href="#" class="book-pic">
						<img src="img/book-list/article/5.jpg">
					</a>
					<a href="#" class="book-info">
						<h5 class="book-name">神曲</h5>
						<span class="book-detail">但丁 著；/ 北京燕山出版社 / 2005-07 / 平装</span>
					</a>
					<span class="book-price">￥11.2
						<a href="#" class="book-buy">立即下单</a>
					</span>
				</li>
			</ul><!--  book-list end -->
		</div><!--  book-part end -->

		<div class="book-part" id="technology">
			<h3 class="book-title"><a href="#">|工程 / 计算机</a></h3>
			<a class="more" href="#"> > > 更多</a>
			<ul class="book-lists">
				<li class="book-list">
					<a href="#" class="book-pic">
						<img src="img/book-list/article/6.jpg">
					</a>
					<a href="#" class="book-info">
						<h5 class="book-name">SpringBoot揭秘：<br>快速构建微服务体系 </h5>
						<span class="book-detail">王福强等 著 / 机械工业出版社 / 2017-01 / 平装</span>
					</a>
					<span class="book-price">￥12.9
						<a href="#" class="book-buy">立即下单</a>
					</span>
				</li>

				<li class="book-list">
					<a href="#" class="book-pic">
						<img src="img/book-list/article/7.jpg">
					</a>
					<a href="#" class="book-info">
						<h5 class="book-name">Python人脸识别：<br>从入门到工程实践 </h5>
						<span class="book-detail">王天庆 著 / 上海图书出版公司 / 2011-10 / 平装</span>
					</a>
					<span class="book-price">￥13.8
						<a href="#" class="book-buy">立即下单</a>
					</span>
				</li>				

				<li class="book-list">
					<a href="#" class="book-pic">
						<img src="img/book-list/article/8.jpg">
					</a>
					<a href="#" class="book-info">
						<h5 class="book-name">神经网络与深度学习实战：<br>Python+Keras+TensorFlow</h5>
						<span class="book-detail">陈屹 著 / 译林出版社 / 2016-06 / 平装</span>
					</a>
					<span class="book-price">￥10.8
						<a href="#" class="book-buy">立即下单</a>
					</span>
				</li>				

				<li class="book-list">
					<a href="#" class="book-pic">
						<img src="img/book-list/article/9.jpg">
					</a>
					<a href="#" class="book-info">
						<h5 class="book-name">机器学习：<br>实用案例解析</h5>
						<span class="book-detail">德鲁 康威 作者 / 世界图书出版社 / 2004-05 / 平装</span>
					</a>
					<span class="book-price">￥12.1
						<a href="#" class="book-buy">立即下单</a>
					</span>
				</li>				
			</ul><!--  book-list end -->
		</div><!--  book-part end -->		
	</div> <!-- container end-->
	<footer>
		<a href="#">©2021 二手书交易</a>
		<a href="#">意见反馈&nbsp;&nbsp;&nbsp;联系我们&nbsp;&nbsp;&nbsp;隐私权声明&nbsp;&nbsp;&nbsp;使用条款</a>
	</footer>
	<script type="text/javascript" src="js/jquery-3.2.js"></script>
	<script type="text/javascript" src="js/xSlider.js"></script>
	<script type="text/javascript">
		$(function(){

			$(".book-class li a").on("click",function(){
				var classId = $(this).prop("title");
				console.log(classId);
				var classTop =  $("#container").find(("#"+classId)).offset().top; 
				$("html,body").animate({scrollTop:classTop+ "px"}, 500);
			});
		})		
    </script>
</body>
</html>