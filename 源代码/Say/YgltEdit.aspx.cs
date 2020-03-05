using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class YGLT_YgltEdit : System.Web.UI.Page
{
    public string strHfList;
    protected void Page_Load(object sender, EventArgs e)
    {
        // 在此处放置用户代码以初始化页面
        //显示当前编号的主题信息
        DataTable tmpda = new DataTable();
        tmpda = DataControl.GetData("select * from 答疑 where 主题编号=" + Request.QueryString["ID"]);
        if (tmpda.Rows.Count > 0)
        {
            this.TZtbt.InnerHtml = "主题标题：" + tmpda.Rows[0]["主题标题"];
            this.Tyhm.InnerHtml = tmpda.Rows[0]["名称"].ToString() + "[" + tmpda.Rows[0]["类型"].ToString() + "]";
            this.Tztnr.InnerHtml = "主题内容：" + tmpda.Rows[0]["主题内容"];
            this.Tfbsj.InnerHtml = "留言时间：" + Convert.ToDateTime(tmpda.Rows[0]["留言时间"]).Date.ToShortDateString();
        }
        //循环显示当前编号的主题回复信息列表
        tmpda = DataControl.GetData("select * from 信息回复 where 主题编号=" + Request.QueryString["ID"]);
        strHfList = "";
        for (int i = 0; i < tmpda.Rows.Count; i++)
        {
            strHfList = strHfList + "<tr>";
            string strTmpHFList;
            strTmpHFList = "<td class='smallText'oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='left' width='20%' > " + tmpda.Rows[i]["名称"].ToString() + "[" + tmpda.Rows[i]["类型"].ToString() + "]" + "</td>";
            strTmpHFList = strTmpHFList + "<td class='smallText'oncontextmenu='return(false)' onselectstart='return false' vAlign='top' noWrap align='left' width='500' > 回复内容：" + tmpda.Rows[i]["回复内容"].ToString().Replace("\r\n", "<br>") + "<br>回复时间：" + Convert.ToDateTime(tmpda.Rows[i]["回复时间"].ToString()).Date.ToShortDateString() + "<br></td>";
            strHfList = strHfList + strTmpHFList + "</tr>";
        }

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        //关闭页面
        Response.Write("<script>window.close();</script>");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //打开窗体
        Response.Write("<script>window.open('AddHf.aspx?ID=" + Request.QueryString["ID"] + "')</script>");
    }
}
