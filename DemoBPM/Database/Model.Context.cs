﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoBPM.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbInputField> tbInputFields { get; set; }
        public virtual DbSet<tbInputFieldInstance> tbInputFieldInstances { get; set; }
        public virtual DbSet<tbInputFieldType> tbInputFieldTypes { get; set; }
        public virtual DbSet<tbRequest> tbRequests { get; set; }
        public virtual DbSet<tbRequestInstance> tbRequestInstances { get; set; }
        public virtual DbSet<tbRole> tbRoles { get; set; }
        public virtual DbSet<tbStep> tbSteps { get; set; }
        public virtual DbSet<tbStepInstance> tbStepInstances { get; set; }
        public virtual DbSet<tbUser> tbUsers { get; set; }
        public virtual DbSet<tbUserRole> tbUserRoles { get; set; }
        public virtual DbSet<tbDeviceToken> tbDeviceTokens { get; set; }
    
        public virtual ObjectResult<sp_GetUserRole_Result> sp_GetUserRole()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetUserRole_Result>("sp_GetUserRole");
        }
    
        public virtual ObjectResult<sp_GetStepInstanceDetails_Result> sp_GetStepInstanceDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetStepInstanceDetails_Result>("sp_GetStepInstanceDetails");
        }
    
        public virtual ObjectResult<sp_GetNumOfRequestInstance_Result> sp_GetNumOfRequestInstance()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetNumOfRequestInstance_Result>("sp_GetNumOfRequestInstance");
        }
    
        public virtual ObjectResult<sp_GetNumOfRequestInstanceToday_Result> sp_GetNumOfRequestInstanceToday()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetNumOfRequestInstanceToday_Result>("sp_GetNumOfRequestInstanceToday");
        }
    
        public virtual ObjectResult<sp_GetInputFieldInstance_Result> sp_GetInputFieldInstance()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetInputFieldInstance_Result>("sp_GetInputFieldInstance");
        }
    
        public virtual ObjectResult<sp_GetRequestInstanceExpan_Result> sp_GetRequestInstanceExpan(Nullable<int> requestInstanceID)
        {
            var requestInstanceIDParameter = requestInstanceID.HasValue ?
                new ObjectParameter("RequestInstanceID", requestInstanceID) :
                new ObjectParameter("RequestInstanceID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetRequestInstanceExpan_Result>("sp_GetRequestInstanceExpan", requestInstanceIDParameter);
        }
    
        public virtual ObjectResult<sp_GetRequestInstance_Result> sp_GetRequestInstance()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetRequestInstance_Result>("sp_GetRequestInstance");
        }
    }
}
