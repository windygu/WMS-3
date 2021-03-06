﻿using System;
namespace WMS_Database
{
    /// <summary>
    /// View_PlanList:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class View_PlanListModel
    {
        public View_PlanListModel()
        { }
        #region Model
        private string _plan_id;
        private string _goods_class_id;
        private string _goods_code;
        private string _goods_name;
        private string _goods_type;
        private string _goods_suppier_code;
        private string _goods_model;
        private string _goods_desc;
        private string _goods_level;
        private string _goods_unit;
        private string _goods_limit_upper_quantity;
        private string _goods_limit_lower_quantity;
        private int? _goods_order;
        private string _goods_flag;
        private string _goods_remark;
        private string _goods_department;
        private int? _goods_shelf_life;
        private string _goods_asset;
        private DateTime? _goods_producedate;
        private string _goods_danger;
        private string _goods_category;
        private string _goods_class_parent_id;
        private string _goods_class_code;
        private string _goods_class_name;
        private string _goods_class_remark;
        private int? _goods_class_order;
        private string _goods_class_flag;
        private string _goods_class_reserve1;
        private string _goods_class_reserve2;
        private string _plan_list_quantity;
        private string _plan_list_ordered_quantity;
        private string _plan_list_finished_quantity;
        private string _goods_id;
        private string _plan_list_status;
        private string _plan_list_remark;
        private string _plan_list_resever1;
        private string _plan_list_resever2;
        private string _plan_list_id;
        private string _plan_type_id;
        private string _plan_serial_num;
        private string _plan_code;
        private DateTime? _plan_create_time;
        private DateTime? _plan_begin_time;
        private DateTime? _plan_end_time;
        private DateTime? _plan_bill_time;
        private string _plan_status;
        private string _plan_operater;
        private string _plan_from_dept;
        private string _plan_to_dept;
        private string _plan_from_user;
        private string _plan_to_user;
        private string _plan_import_flag;
        private string _plan_remark;
        private string _plan_type_code;
        private string _plan_type_name;
        private string _plan_type_group;
        private string _plan_type_inout;
        private int? _plan_type_order;
        private string _plan_type_remark;
        private string _plan_type_flag;
        private string _goods_batch;
        /// <summary>
        /// 
        /// </summary>
        public string Plan_ID
        {
            set { _plan_id = value; }
            get { return _plan_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_ID
        {
            set { _goods_class_id = value; }
            get { return _goods_class_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Code
        {
            set { _goods_code = value; }
            get { return _goods_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Name
        {
            set { _goods_name = value; }
            get { return _goods_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Type
        {
            set { _goods_type = value; }
            get { return _goods_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Suppier_Code
        {
            set { _goods_suppier_code = value; }
            get { return _goods_suppier_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Model
        {
            set { _goods_model = value; }
            get { return _goods_model; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Desc
        {
            set { _goods_desc = value; }
            get { return _goods_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Level
        {
            set { _goods_level = value; }
            get { return _goods_level; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Unit
        {
            set { _goods_unit = value; }
            get { return _goods_unit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Limit_Upper_Quantity
        {
            set { _goods_limit_upper_quantity = value; }
            get { return _goods_limit_upper_quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Limit_Lower_Quantity
        {
            set { _goods_limit_lower_quantity = value; }
            get { return _goods_limit_lower_quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Goods_Order
        {
            set { _goods_order = value; }
            get { return _goods_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Flag
        {
            set { _goods_flag = value; }
            get { return _goods_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Remark
        {
            set { _goods_remark = value; }
            get { return _goods_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Department
        {
            set { _goods_department = value; }
            get { return _goods_department; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Goods_Shelf_Life
        {
            set { _goods_shelf_life = value; }
            get { return _goods_shelf_life; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Asset
        {
            set { _goods_asset = value; }
            get { return _goods_asset; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Goods_ProduceDate
        {
            set { _goods_producedate = value; }
            get { return _goods_producedate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Danger
        {
            set { _goods_danger = value; }
            get { return _goods_danger; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Category
        {
            set { _goods_category = value; }
            get { return _goods_category; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Parent_ID
        {
            set { _goods_class_parent_id = value; }
            get { return _goods_class_parent_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Code
        {
            set { _goods_class_code = value; }
            get { return _goods_class_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Name
        {
            set { _goods_class_name = value; }
            get { return _goods_class_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Remark
        {
            set { _goods_class_remark = value; }
            get { return _goods_class_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Goods_Class_Order
        {
            set { _goods_class_order = value; }
            get { return _goods_class_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Flag
        {
            set { _goods_class_flag = value; }
            get { return _goods_class_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Reserve1
        {
            set { _goods_class_reserve1 = value; }
            get { return _goods_class_reserve1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Class_Reserve2
        {
            set { _goods_class_reserve2 = value; }
            get { return _goods_class_reserve2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_List_Quantity
        {
            set { _plan_list_quantity = value; }
            get { return _plan_list_quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_List_Ordered_Quantity
        {
            set { _plan_list_ordered_quantity = value; }
            get { return _plan_list_ordered_quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_List_Finished_Quantity
        {
            set { _plan_list_finished_quantity = value; }
            get { return _plan_list_finished_quantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_ID
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_List_Status
        {
            set { _plan_list_status = value; }
            get { return _plan_list_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_List_Remark
        {
            set { _plan_list_remark = value; }
            get { return _plan_list_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_List_Resever1
        {
            set { _plan_list_resever1 = value; }
            get { return _plan_list_resever1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_List_Resever2
        {
            set { _plan_list_resever2 = value; }
            get { return _plan_list_resever2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_List_ID
        {
            set { _plan_list_id = value; }
            get { return _plan_list_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_ID
        {
            set { _plan_type_id = value; }
            get { return _plan_type_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Serial_Num
        {
            set { _plan_serial_num = value; }
            get { return _plan_serial_num; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Code
        {
            set { _plan_code = value; }
            get { return _plan_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Plan_Create_Time
        {
            set { _plan_create_time = value; }
            get { return _plan_create_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Plan_Begin_Time
        {
            set { _plan_begin_time = value; }
            get { return _plan_begin_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Plan_End_Time
        {
            set { _plan_end_time = value; }
            get { return _plan_end_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Plan_Bill_Time
        {
            set { _plan_bill_time = value; }
            get { return _plan_bill_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Status
        {
            set { _plan_status = value; }
            get { return _plan_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Operater
        {
            set { _plan_operater = value; }
            get { return _plan_operater; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_From_Dept
        {
            set { _plan_from_dept = value; }
            get { return _plan_from_dept; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_To_Dept
        {
            set { _plan_to_dept = value; }
            get { return _plan_to_dept; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_From_User
        {
            set { _plan_from_user = value; }
            get { return _plan_from_user; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_To_User
        {
            set { _plan_to_user = value; }
            get { return _plan_to_user; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Import_Flag
        {
            set { _plan_import_flag = value; }
            get { return _plan_import_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Remark
        {
            set { _plan_remark = value; }
            get { return _plan_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_Code
        {
            set { _plan_type_code = value; }
            get { return _plan_type_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_Name
        {
            set { _plan_type_name = value; }
            get { return _plan_type_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_Group
        {
            set { _plan_type_group = value; }
            get { return _plan_type_group; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_InOut
        {
            set { _plan_type_inout = value; }
            get { return _plan_type_inout; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Plan_Type_Order
        {
            set { _plan_type_order = value; }
            get { return _plan_type_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_Remark
        {
            set { _plan_type_remark = value; }
            get { return _plan_type_remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Plan_Type_Flag
        {
            set { _plan_type_flag = value; }
            get { return _plan_type_flag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Goods_Batch
        {
            set { _goods_batch = value; }
            get { return _goods_batch; }
        }
        #endregion Model

    }
}

