﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Library
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LibraryEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LibraryEntities object using the connection string found in the 'LibraryEntities' section of the application configuration file.
        /// </summary>
        public LibraryEntities() : base("name=LibraryEntities", "LibraryEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibraryEntities object.
        /// </summary>
        public LibraryEntities(string connectionString) : base(connectionString, "LibraryEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibraryEntities object.
        /// </summary>
        public LibraryEntities(EntityConnection connection) : base(connection, "LibraryEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tblBook> tblBooks
        {
            get
            {
                if ((_tblBooks == null))
                {
                    _tblBooks = base.CreateObjectSet<tblBook>("tblBooks");
                }
                return _tblBooks;
            }
        }
        private ObjectSet<tblBook> _tblBooks;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tblBooks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotblBooks(tblBook tblBook)
        {
            base.AddObject("tblBooks", tblBook);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryModel", Name="tblBook")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tblBook : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tblBook object.
        /// </summary>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="author">Initial value of the Author property.</param>
        /// <param name="year">Initial value of the Year property.</param>
        /// <param name="impression">Initial value of the Impression property.</param>
        /// <param name="printRun">Initial value of the PrintRun property.</param>
        /// <param name="publisher">Initial value of the Publisher property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        /// <param name="iSBN">Initial value of the ISBN property.</param>
        /// <param name="bookID">Initial value of the BookID property.</param>
        /// <param name="regDate">Initial value of the RegDate property.</param>
        /// <param name="count">Initial value of the Count property.</param>
        public static tblBook CreatetblBook(global::System.String title, global::System.String author, global::System.String year, global::System.Int32 impression, global::System.Int16 printRun, global::System.String publisher, global::System.Decimal price, global::System.String iSBN, global::System.String bookID, global::System.String regDate, global::System.Int32 count)
        {
            tblBook tblBook = new tblBook();
            tblBook.Title = title;
            tblBook.Author = author;
            tblBook.Year = year;
            tblBook.Impression = impression;
            tblBook.PrintRun = printRun;
            tblBook.Publisher = publisher;
            tblBook.Price = price;
            tblBook.ISBN = iSBN;
            tblBook.BookID = bookID;
            tblBook.RegDate = regDate;
            tblBook.Count = count;
            return tblBook;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Author
        {
            get
            {
                return _Author;
            }
            set
            {
                OnAuthorChanging(value);
                ReportPropertyChanging("Author");
                _Author = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Author");
                OnAuthorChanged();
            }
        }
        private global::System.String _Author;
        partial void OnAuthorChanging(global::System.String value);
        partial void OnAuthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Year
        {
            get
            {
                return _Year;
            }
            set
            {
                OnYearChanging(value);
                ReportPropertyChanging("Year");
                _Year = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Year");
                OnYearChanged();
            }
        }
        private global::System.String _Year;
        partial void OnYearChanging(global::System.String value);
        partial void OnYearChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Impression
        {
            get
            {
                return _Impression;
            }
            set
            {
                OnImpressionChanging(value);
                ReportPropertyChanging("Impression");
                _Impression = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Impression");
                OnImpressionChanged();
            }
        }
        private global::System.Int32 _Impression;
        partial void OnImpressionChanging(global::System.Int32 value);
        partial void OnImpressionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 PrintRun
        {
            get
            {
                return _PrintRun;
            }
            set
            {
                OnPrintRunChanging(value);
                ReportPropertyChanging("PrintRun");
                _PrintRun = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PrintRun");
                OnPrintRunChanged();
            }
        }
        private global::System.Int16 _PrintRun;
        partial void OnPrintRunChanging(global::System.Int16 value);
        partial void OnPrintRunChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Publisher
        {
            get
            {
                return _Publisher;
            }
            set
            {
                OnPublisherChanging(value);
                ReportPropertyChanging("Publisher");
                _Publisher = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Publisher");
                OnPublisherChanged();
            }
        }
        private global::System.String _Publisher;
        partial void OnPublisherChanging(global::System.String value);
        partial void OnPublisherChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.Decimal _Price;
        partial void OnPriceChanging(global::System.Decimal value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ISBN
        {
            get
            {
                return _ISBN;
            }
            set
            {
                OnISBNChanging(value);
                ReportPropertyChanging("ISBN");
                _ISBN = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ISBN");
                OnISBNChanged();
            }
        }
        private global::System.String _ISBN;
        partial void OnISBNChanging(global::System.String value);
        partial void OnISBNChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BookID
        {
            get
            {
                return _BookID;
            }
            set
            {
                if (_BookID != value)
                {
                    OnBookIDChanging(value);
                    ReportPropertyChanging("BookID");
                    _BookID = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("BookID");
                    OnBookIDChanged();
                }
            }
        }
        private global::System.String _BookID;
        partial void OnBookIDChanging(global::System.String value);
        partial void OnBookIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RegDate
        {
            get
            {
                return _RegDate;
            }
            set
            {
                OnRegDateChanging(value);
                ReportPropertyChanging("RegDate");
                _RegDate = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("RegDate");
                OnRegDateChanged();
            }
        }
        private global::System.String _RegDate;
        partial void OnRegDateChanging(global::System.String value);
        partial void OnRegDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Count
        {
            get
            {
                return _Count;
            }
            set
            {
                OnCountChanging(value);
                ReportPropertyChanging("Count");
                _Count = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Count");
                OnCountChanged();
            }
        }
        private global::System.Int32 _Count;
        partial void OnCountChanging(global::System.Int32 value);
        partial void OnCountChanged();

        #endregion
    
    }

    #endregion
    
}
