using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_SXSSee : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsCallback)
        {
            BindResult();
        }

    }
    #region 数据绑定
    /// <summary>
    ///绑定列表
    /// </summary>
    private void BindResult()
    {

        //组合查询条件 
        DataTable dt=null;
        if (Request.QueryString["LB"] != null)
        {
            dt = DataControl.GetData("select * from  实习生 where 学号 in (select 学号 from V_安排 where 单位类别='"+Request.QueryString["LB"]+"')");

        }
        if (Request.QueryString["DWID"] != null)
        {
            dt = DataControl.GetData("select * from  实习生 where 学号 in (select 学号 from V_安排 where 单位编号=" + Request.QueryString["DWID"] + ")");

        }
        if (Request.QueryString["WCQK"] != null)
        {
            dt = DataControl.GetData("select * from  实习生 where 学号 in (select 学号 from V_安排 where 完成情况='" + Request.QueryString["WCQK"] + "')");

        }
        if (dt != null)
        {
            this.gvData.DataKeyNames = new string[] { "学号" };
            this.gvData.DataSource = dt;
            this.gvData.DataBind();
            ShowStats(dt.Rows.Count.ToString());
        }
    }

    #endregion
    #region 设置翻页按钮事件
    public void PagerButtonClick(object sender, EventArgs e)
    {
        string arg = ((LinkButton)sender).CommandArgument.ToString();
        switch (arg)
        {
            case "next":
                if (gvData.PageIndex < (this.gvData.PageCount - 1))
                {
                    gvData.PageIndex += 1;
                }
                break;
            case "prev":
                if (gvData.PageIndex > 0)
                {
                    gvData.PageIndex -= 1;
                }
                break;
            case "last":
                if (gvData.PageCount != 0)
                {
                    gvData.PageIndex = (gvData.PageCount - 1);
                }
                else
                {
                    gvData.PageIndex = 0;
                }
                break;
            default:
                gvData.PageIndex = System.Convert.ToInt32(arg);
                break;
        }
        //绑定列表
        BindResult();

    }
    #endregion
    #region 刷新列表下的统计信息
    private void ShowStats(string strRowNum)
    {
        lblCurrentIndex.Text = "第<font color=#ff0000>" + (this.gvData.PageIndex + 1).ToString() + "</font>页";
        lblPageCount.Text = "共<font color=#ff0000>" + gvData.PageCount.ToString() + "</font>页";
        lblCount.Text = "共<font color=#ff0000>" + strRowNum + "</font>条记录";
    }

    #endregion
    #region 按钮事件
    /// <summary>
    /// 查询
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void BtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        BindResult();
    }
    #endregion
    #region 列表事件

    /// <summary>
    /// 单击行事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvData_RowCommand(object sender, GridViewCommandEventArgs e)
    {
     
    }

    /// <summary>
    /// 列表创建事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvData_RowCreated(object sender, GridViewRowEventArgs e)
    {
      
    }
    /// <summary>
    /// 绑定数据事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
       
    }

    #endregion
    protected void btnAdd_Click(object sender, ImageClickEventArgs e)
    {
        
    }
}
