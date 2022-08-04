<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personalInfo.aspx.cs" Inherits="WebRestClient.index" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>旧书买卖系统</title>
    <link rel="stylesheet" type="text/css" href="css/common.css"/>
    <link rel="stylesheet" type="text/css" href="css/main.css"/>
    <script type="text/javascript" src="js/libs/modernizr.min.js"></script>
</head>
<body runat="server">
<div class="topbar-wrap white">
    <div class="topbar-inner clearfix">
        <div class="topbar-logo-wrap clearfix">
            <h1 class="topbar-logo none"><a href="index.aspx" class="navbar-brand">后台管理</a></h1>
            <ul class="navbar-list clearfix">
                <li><a class="on" href="index.aspx">首页</a></li>
               <%-- <li><a href="#" target="_blank">网站首页</a></li>--%>
            </ul>
        </div>
        <div class="top-info-wrap">
            <ul class="top-info-list clearfix">
                <li><a href="#">管理员</a></li>
                <li><a href="#">修改密码</a></li>
                <li><a href="#">退出</a></li>
            </ul>
        </div>
    </div>
</div>
<div class="container clearfix" >
    <div class="sidebar-wrap">
        <div class="sidebar-title">
            <h1>菜单</h1>
        </div>
        <div class="sidebar-content">
            <ul class="sidebar-list">
                
                <li>
                   
                    <a href="#"><i class="icon-font">&#xe018;</i>系统管理</a>
                    <ul class="sub-menu">                       
                        <li><a href="changePersonalInfo.aspx"><i class="icon-font">&#xe017;</i>信息修改</a></li>
                    </ul>
                    <%--<ul class="sub-menu">
                         <li><a href="changePersonalInfo.aspx"><i class="icon-font">&#xe017;</i>删除用户</a></li>
                    </ul>--%>
                   
                </li>
            </ul>
        </div>
    </div>
    <!--/sidebar-->
    <div class="main-wrap">
        <div class="crumb-wrap">
            <div class="crumb-list"><i class="icon-font">&#xe06b;</i><span>欢迎使用『旧书买卖系统』。</span></div>
        </div>
        <div class="result-wrap">
            <div class="result-title">
                <h1>快捷操作</h1>
            </div>
            <div class="result-content">
                <div class="short-wrap">
                    <a href="changePersonalInfo.aspx"><i class="icon-font">&#xe001;</i>修改用户信息</a>
                </div>
            </div>
        </div>
        <div class="result-wrap">
            <div class="result-title">
                <h1>用户基本信息</h1>
            </div>
            <div class="result-content">
                <ul class="sys-info-list">
                     <li>
                        <label class="res-lab">ID</label><span asp:TextBox ID="id" runat="server" class="res-info">1</span>
                    </li>
                    <li>
                        <label class="res-lab">UID</label><span asp:TextBox ID="uid" runat="server" class="res-info">2019302110281</span>
                    </li>
                    <li>
                        <label class="res-lab">用户名</label><span asp:TextBox ID="name" runat="server" type="text" class="res-info">xlf</span>
                    </li>
                    <li>
                        <label class="res-lab" >密码</label><span asp:TextBox ID="password" runat="server" type="text" class="res-info" >12345678</span>
                    </li>
                    <li>
                        <label class="res-lab">联系方式</label><span asp:TextBox ID="tel" runat="server" type="text" class="res-info" >13623116586</span>
                    </li>
                    <li>
                        <label class="res-lab">地址</label><span asp:TextBox ID="address" runat="server" type="text" class="res-info" onserverchange ="change">湖北省武汉大学信息学部</span>
                    </li>
                </ul>
                <form method="post" id="myform" name="myform"  runat="server">
                  
<%--                  <input asp:button ID="submit1" runat="server" type="submit" value="提交" class="btn btn-primary btn6 mr10" onserverclick="SubmitInfo"/>--%>
<%--                   <asp:Button id="signup" text="注册" CssClass="submit" runat="server" OnClick="SignUp"/>--%>
<%--                    <asp:Button id="delete" text="注销账户" type="submit" runat="server" OnClientClick="DeleteUser" />--%>
                  <input asp:Button ID="submit2" runat="server" type="submit" value="注销账户" class="btn btn-primary btn6 mr10" onserverclick="DeleteUser" />
                </form>
            </div>
        </div>
        <div class="result-wrap">
            <div class="result-title">
                <h1>使用帮助</h1>
            </div>
            <div class="result-content">
                <ul class="sys-info-list">
                    
                    <li>
                        
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <!--/main-->
</div>
<style>
.copyrights{text-indent:-9999px;height:0;line-height:0;font-size:0;overflow:hidden;}
</style>
</body>
</html>
