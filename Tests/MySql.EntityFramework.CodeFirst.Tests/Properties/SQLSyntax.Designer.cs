﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySql.Data.Entity.CodeFirst.Tests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SQLSyntax {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SQLSyntax() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MySql.Data.Entity.CodeFirst.Tests.Properties.SQLSyntax", typeof(SQLSyntax).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`, 
        ///`Project3`.`nCdSite`, 
        ///`Project3`.`C1` AS `C2`
        ///FROM (SELECT
        ///`visitante`.`nCdSite`, 
        ///COUNT(DISTINCT `visitante`.`sDsIp`) AS `C1`
        ///FROM `visitante`
        /// GROUP BY 
        ///`visitante`.`nCdSite`) AS `Project3`.
        /// </summary>
        internal static string CountGroupBy {
            get {
                return ResourceManager.GetString("CountGroupBy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`, 
        ///`Project3`.`nCdSite`, 
        ///`Project3`.`C1` AS `C2`
        ///FROM (SELECT
        ///`Extent4`.`nCdSite`, 
        ///COUNT(DISTINCT `Extent4`.`sDsIp`) AS `C1`
        ///FROM `pagina` AS `Extent3` INNER JOIN `visitante` AS `Extent4` ON `Extent3`.`nCdVisitante` = `Extent4`.`nCdVisitante`
        /// GROUP BY 
        ///`Extent4`.`nCdSite`) AS `Project3`.
        /// </summary>
        internal static string CountGroupBy2 {
            get {
                return ResourceManager.GetString("CountGroupBy2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`,
        ///`Project3`.`nCdSite`,
        ///`Project3`.`C1` AS `C2`
        ///FROM (SELECT
        ///`Extent4`.`nCdSite`,
        ///COUNT(DISTINCT `Extent4`.`sDsIp`) AS `C1`
        ///FROM `pagina` AS `Extent3` INNER JOIN `visitante` AS `Extent4` ON `Extent3`.`nCdVisitante`=`Extent4`.`nCdVisitante`
        ///GROUP BY `Extent4`.`nCdSite`) AS `Project3`
        ///  .
        /// </summary>
        internal static string CountGroupBy2EF5 {
            get {
                return ResourceManager.GetString("CountGroupBy2EF5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///1 AS `C1`, 
        ///`Project3`.`nCdSite`, 
        ///`Project3`.`C1` AS `C2`
        ///FROM (SELECT
        ///`visitante`.`nCdSite`, 
        ///COUNT(DISTINCT `visitante`.`sDsIp`) AS `C1`
        ///FROM `visitante`
        /// GROUP BY 
        ///`visitante`.`nCdSite`) AS `Project3`.
        /// </summary>
        internal static string CountGroupByEF5 {
            get {
                return ResourceManager.GetString("CountGroupByEF5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  `Apply1`.`customer_id`, 
        ///  `Extent5`.`country`
        ///  FROM (SELECT
        ///  `Extent1`.`customer_id`, 
        ///  `Extent1`.`store_id`, 
        ///  `Extent1`.`first_name`, 
        ///  `Extent1`.`last_name`, 
        ///  `Extent1`.`email`, 
        ///  `Extent1`.`address_id`, 
        ///  `Extent1`.`active`, 
        ///  `Extent1`.`create_date`, 
        ///  `Extent1`.`last_update`, 
        ///  (SELECT
        ///  `Project1`.`address_id`
        ///  FROM `address` AS `Project1`
        ///   WHERE `Project1`.`address_id` = `Extent1`.`address_id`
        ///   ORDER BY 
        ///  `Project1`.`address_id` DESC LIMIT 1) AS `ADDRESS [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FirstOrDefaultNestedWithOrderBy {
            get {
                return ResourceManager.GetString("FirstOrDefaultNestedWithOrderBy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  `Project1`.`ID`, 
        ///  `Project1`.`Title`, 
        ///  `Project1`.`ReleaseDate`, 
        ///  `Project1`.`Genre`, 
        ///  `Project1`.`Price`, 
        ///  `Project1`.`Data`, 
        ///  `Project1`.`Director_ID`
        ///  FROM `Movies` AS `Project1`
        ///   WHERE `Project1`.`ReleaseDate` &gt;= @p__linq__0
        ///   ORDER BY 
        ///  `Project1`.`ReleaseDate` DESC LIMIT 2.
        /// </summary>
        internal static string NestedOrderBy {
            get {
                return ResourceManager.GetString("NestedOrderBy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`ID`, 
        ///`Extent1`.`Title`, 
        ///`Extent1`.`ReleaseDate`, 
        ///`Extent1`.`Genre`, 
        ///`Extent1`.`Price`, 
        ///`Extent1`.`Data`, 
        ///`Extent1`.`Director_ID`
        ///FROM `Movies` AS `Extent1`
        /// WHERE `Extent1`.`Title` LIKE @p__linq__0.
        /// </summary>
        internal static string QueryWithContains {
            get {
                return ResourceManager.GetString("QueryWithContains", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`ID`, 
        ///`Extent1`.`Title`, 
        ///`Extent1`.`ReleaseDate`, 
        ///`Extent1`.`Genre`, 
        ///`Extent1`.`Price`, 
        ///`Extent1`.`Data`, 
        ///`Extent1`.`Director_ID`
        ///FROM `Movies` AS `Extent1`
        /// WHERE `Extent1`.`Title` LIKE @p__linq__0.
        /// </summary>
        internal static string QueryWithEndsWith {
            get {
                return ResourceManager.GetString("QueryWithEndsWith", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project1`.`ID`, 
        ///`Project1`.`Title`, 
        ///`Project1`.`ReleaseDate`, 
        ///`Project1`.`Genre`, 
        ///`Project1`.`Price`, 
        ///`Project1`.`Data`, 
        ///`Project1`.`Director_ID`
        ///FROM `Movies` AS `Project1`
        /// WHERE `Project1`.`Title` LIKE @p__linq__0
        /// ORDER BY 
        ///`Project1`.`ID` DESC LIMIT 10.
        /// </summary>
        internal static string QueryWithOrderByTakeContains {
            get {
                return ResourceManager.GetString("QueryWithOrderByTakeContains", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`ID`, 
        ///`Extent1`.`Title`, 
        ///`Extent1`.`ReleaseDate`, 
        ///`Extent1`.`Genre`, 
        ///`Extent1`.`Price`, 
        ///`Extent1`.`Data`, 
        ///`Extent1`.`Director_ID`
        ///FROM `Movies` AS `Extent1`
        /// WHERE `Extent1`.`Title` LIKE @p__linq__0.
        /// </summary>
        internal static string QueryWithStartsWith {
            get {
                return ResourceManager.GetString("QueryWithStartsWith", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  `Project2`.`customer_id`, 
        ///  `Project2`.`store_id`, 
        ///  `Project2`.`first_name`, 
        ///  `Project2`.`last_name`, 
        ///  `Project2`.`email`, 
        ///  `Project2`.`address_id`, 
        ///  `Project2`.`active`, 
        ///  `Project2`.`create_date`, 
        ///  `Project2`.`last_update`
        ///  FROM `customer` AS `Project2`
        ///   WHERE EXISTS(SELECT
        ///  1 AS `C1`
        ///  FROM `rental` AS `Extent2`
        ///   WHERE (`Project2`.`customer_id` = `Extent2`.`customer_id`) AND (`Extent2`.`rental_date` &lt; @p__linq__0))
        ///   ORDER BY 
        ///  `Project2`.`customer_id` ASC.
        /// </summary>
        internal static string ReplaceNameVisitorQuery {
            get {
                return ResourceManager.GetString("ReplaceNameVisitorQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT `Project1`.`HarborId`,`Project1`.`Description`,`Project1`.`C2` AS `C1`,`Project1`.`ShipId`,`Project1`.`HarborId1`,`Project1`.`Description1`,`Project1`.`C1` AS `C2`,`Project1`.`CrewMemberId`,`Project1`.`ShipId1`,`Project1`.`RankId`,`Project1`.`ClearanceId`,`Project1`.`Description2`,`Project1`.`RankId1`,`Project1`.`Description3`,`Project1`.`ClearanceId1`,`Project1`.`Description4`
        ///FROM (SELECT `Extent1`.`HarborId`,`Extent1`.`Description`,`Join3`.`ShipId`,`Join3`.`HarborId` AS `HarborId1`,`Join3`.`Descr [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ShipQueryMalformedDueMultipleProjecttionsCorrected {
            get {
                return ResourceManager.GetString("ShipQueryMalformedDueMultipleProjecttionsCorrected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project1`.`HarborId`, 
        ///`Project1`.`Description`, 
        ///`Project1`.`C2` AS `C1`, 
        ///`Project1`.`ShipId`, 
        ///`Project1`.`HarborId1`, 
        ///`Project1`.`Description1`, 
        ///`Project1`.`C1` AS `C2`, 
        ///`Project1`.`CrewMemberId`, 
        ///`Project1`.`ShipId1`, 
        ///`Project1`.`RankId`, 
        ///`Project1`.`ClearanceId`, 
        ///`Project1`.`Description2`, 
        ///`Project1`.`RankId1`, 
        ///`Project1`.`Description3`, 
        ///`Project1`.`ClearanceId1`, 
        ///`Project1`.`Description4`
        ///FROM (SELECT
        ///`Extent1`.`HarborId`, 
        ///`Extent1`.`Description`, 
        ///`Join3`.`Shi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ShipQueryMalformedDueMultipleProjecttionsCorrectedEF6 {
            get {
                return ResourceManager.GetString("ShipQueryMalformedDueMultipleProjecttionsCorrectedEF6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  `Extent1`.`ID`, 
        ///  `Extent1`.`Title`, 
        ///  `Extent1`.`ReleaseDate`, 
        ///  `Extent1`.`Genre`, 
        ///  `Extent1`.`Price`, 
        ///  `Extent1`.`Data`, 
        ///  `Extent1`.`Director_ID`
        ///  FROM `Movies` AS `Extent1`
        ///   WHERE (@gp1 IN ( @gp2 )) AND (@gp3 IS NOT NULL).
        /// </summary>
        internal static string TestContainsListWitConstant {
            get {
                return ResourceManager.GetString("TestContainsListWitConstant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`ID`, 
        ///`Extent1`.`Title`, 
        ///`Extent1`.`ReleaseDate`, 
        ///`Extent1`.`Genre`, 
        ///`Extent1`.`Price`, 
        ///`Extent1`.`Data`, 
        ///`Extent1`.`Director_ID`
        ///FROM `Movies` AS `Extent1`
        /// WHERE @gp1 = @gp2.
        /// </summary>
        internal static string TestContainsListWitConstantEF5 {
            get {
                return ResourceManager.GetString("TestContainsListWitConstantEF5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  `Extent1`.`ID`, 
        ///  `Extent1`.`Title`, 
        ///  `Extent1`.`ReleaseDate`, 
        ///  `Extent1`.`Genre`, 
        ///  `Extent1`.`Price`, 
        ///  `Extent1`.`Data`, 
        ///  `Extent1`.`Director_ID`
        ///  FROM `Movies` AS `Extent1`
        ///   WHERE (`Extent1`.`ID` IN ( 1,2,3 )) AND (`Extent1`.`ID` IS NOT NULL).
        /// </summary>
        internal static string TestContainsListWithCast {
            get {
                return ResourceManager.GetString("TestContainsListWithCast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`ID`, 
        ///`Extent1`.`Title`, 
        ///`Extent1`.`ReleaseDate`, 
        ///`Extent1`.`Genre`, 
        ///`Extent1`.`Price`, 
        ///`Extent1`.`Data`, 
        ///`Extent1`.`Director_ID`
        ///FROM `Movies` AS `Extent1`
        /// WHERE `Extent1`.`ID` IN ( 1,2,3 ).
        /// </summary>
        internal static string TestContainsListWithCastEF5 {
            get {
                return ResourceManager.GetString("TestContainsListWithCastEF5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`ID`, 
        ///`Extent1`.`Title`, 
        ///`Extent1`.`ReleaseDate`, 
        ///`Extent1`.`Genre`, 
        ///`Extent1`.`Price`, 
        ///`Extent1`.`Data`, 
        ///`Extent1`.`Director_ID`
        ///FROM `Movies` AS `Extent1`
        /// WHERE @p__linq__0 IN ( 1,2,3 ).
        /// </summary>
        internal static string TestContainsListWithParameterReference {
            get {
                return ResourceManager.GetString("TestContainsListWithParameterReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Extent1`.`ID`, 
        ///`Extent1`.`Title`, 
        ///`Extent1`.`ReleaseDate`, 
        ///`Extent1`.`Genre`, 
        ///`Extent1`.`Price`, 
        ///`Extent1`.`Data`, 
        ///`Extent1`.`Director_ID`
        ///FROM `Movies` AS `Extent1`
        /// WHERE ((1 = @p__linq__0) OR (2 = @p__linq__0)) OR (3 = @p__linq__0).
        /// </summary>
        internal static string TestContainsListWithParameterReferenceEF5 {
            get {
                return ResourceManager.GetString("TestContainsListWithParameterReferenceEF5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///  `Project1`.`ID` AS `C1`
        ///  FROM `Movies` AS `Project1`
        ///   WHERE (`Project1`.`ID`) = @p__linq__0
        ///   ORDER BY 
        ///  `Project1`.`ID` ASC.
        /// </summary>
        internal static string UnknownProjectC1 {
            get {
                return ResourceManager.GetString("UnknownProjectC1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///`Project1`.`ID` AS `C1`
        ///FROM `Movies` AS `Project1`
        /// WHERE (`Project1`.`ID`) = @p__linq__0
        /// ORDER BY 
        ///`Project1`.`ID` ASC.
        /// </summary>
        internal static string UnknownProjectC1EF6 {
            get {
                return ResourceManager.GetString("UnknownProjectC1EF6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `MovieReleases` SET `Name`=&apos;Director\&apos;s Cut&apos; WHERE (`Id` = 1) AND (`Name` = &apos;Commercial&apos;); SELECT `Timestamp` FROM `MovieReleases`  WHERE  row_count() &gt; 0 and (`Id` = 1) AND (`Name` = &apos;Director\&apos;s Cut&apos;).
        /// </summary>
        internal static string UpdateWithSelect {
            get {
                return ResourceManager.GetString("UpdateWithSelect", resourceCulture);
            }
        }
    }
}
