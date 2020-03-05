﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class YGLT_YgltList : System.Web.UI.Page
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
        DataTable dt = DataControl.GetData("select * from  答疑 ");
        if (dt != null)
        {
            this.gvData.DataKeyNames = new string[] { "主题编号" };
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
        int num = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Mod")
        {
              Page.RegisterClientScriptBlock("onload", "<script>window.open('YgltEdit.aspx?ID=" + gvData.DataKeys[num]["主题编号"].ToString() + "'); </script>");

        }
        else if (e.CommandName == "Del")
        {
            DataControl.Execute("delete from 信息回复 where 主题编号=" + gvData.DataKeys[num]["主题编号"].ToString() + "");
            DataControl.Execute("delete from 答疑 where 主题编号=" + gvData.DataKeys[num]["主题编号"].ToString() + "");
            BindResult();
        }
    }

    /// <summary>
    /// 列表创建事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvData_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            LinkButton LinkButton1 = (LinkButton)e.Row.FindControl("btn_Delete");

            LinkButton1.CommandArgument = e.Row.RowIndex.ToString();

            LinkButton LinkButton2 = (LinkButton)e.Row.FindControl("btn_Modify");

            LinkButton2.CommandArgument = e.Row.RowIndex.ToString();

        }
    }
    /// <summary>
    /// 绑定数据事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gvData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)//判定当前的行是否属于datarow类型的行
        {
            //当鼠标放上去的时候 先保存当前行的背景颜色 并给附一颜色
            e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='CFD4E8',this.style.fontWeight='';");
            //当鼠标离开的时候 将背景颜色还原的以前的颜色


            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");

        }
    }

    #endregion
    protected void btnAdd_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("addFb.aspx");
    }
   
}
