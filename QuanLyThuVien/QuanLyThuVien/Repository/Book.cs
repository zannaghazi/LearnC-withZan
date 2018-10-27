using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Repository
{
    public class Book
    {
        public string name { get; set; } //NAME NVARCHAR(255),
        public string author { get; set; } //AUTHOR NVARCHAR(100),
        public string publisher { get; set; }//PUBLISHER NVARCHAR(100),
        public DateTime publisherDate { get; set; }//PUBLISH_DATE DATE,
        public long price { get; set; }//PRICE BIGINT,

        public int newStatus { get; set; }//NEW_STATUS INT,
        public string storageNo { get; set; }//STORAGE_NO VARCHAR(13),
        public string kind { get; set; }//KIND VARCHAR(100),
        public int rentStatus { get; set; }//RENT_STATUS INT,
        public string id { get; set; }//ID VARCHAR(11) PRIMARY KEY,

        public DateTime createdTime { get; set; }//CREATED_TIME DATETIME,
        public string createdStaff { get; set; }//CREATED_STAFF VARCHAR(4),
        public DateTime updatedTime { get; set; }//UPDATED_TIME DATETIME,
        public string updatedStaff { get; set; }//UPDATED_STAFF VARCHAR(4),

        public DateTime rentDate { get; set; }//RENT_DATE DATETIME,
        public string rentStaff { get; set; }//RENT_STAFF VARCHAR(4),
        public string rentUser { get; set; }//RENT_USER VARCHAR(11),

        public DateTime backDate { get; set; }//BACK_DATE DATETIME,
        public string backStaff { get; set; }//BACK_STAFF VARCHAR(4),
        public string backUser { get; set; }//BACK_USER VARCHAR(11),
        public int rentCount { get; set; }//RENT_COUNT INT
        //==================PRIVATE VARIABLES====================
        private static string connectionString = "Data Source=ZAN-PC\\HIEU;Initial Catalog=THUVIEN;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(connectionString);

        private static bool isOpen = false;
        //==================CONSTRANT VARIABLES==================
        // For rentStatus
        public const int RENT = 0;
        public const int IN_LIBRARY = 1;
        public const int DELETED = 2;


        //Constructor
        public Book()
        {

        }

        public Book(string name, string author, string publisher, DateTime publisherDate, long price,
            int newStatus, string storageNo, string kind, int rentStatus, string id, 
            DateTime createdTime, string createdStaff, DateTime updatedTime, string updatedStaff,
            DateTime rentDate, string rentStaff, string rentUser,
            DateTime backDate, string backStaff, string backUser,
            int rentCount)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.publisherDate = publisherDate;
            this.price = price;

            this.newStatus = newStatus;
            this.storageNo = storageNo;
            this.kind = kind;
            this.rentStatus = rentStatus;
            this.id = id;

            this.createdStaff = createdStaff;
            this.createdTime = createdTime;
            this.updatedTime = updatedTime;
            this.updatedStaff = updatedStaff;

            this.rentDate = rentDate;
            this.rentStaff = rentStaff;
            this.rentUser = rentUser;

            this.backUser = backUser;
            this.backStaff = backStaff;
            this.backDate = backDate;
            this.rentCount = rentCount;
        }
        //Operation
        public string toString()
        {
            string result = "Tên: ";
            result += this.name;
            result += ", Tác giả: ";
            result += this.author;
            result += ", Nhà xuât bản: ";
            result += this.publisher;
            result += ", Ngày xuất bản: ";
            result += this.publisherDate.ToLongDateString();
            result += ", Giá: ";
            result += this.price;
            return result;
        }

        public void openConnection()
        {
            try
            {
                conn.Open();
                isOpen = true;
                return;
            } catch(Exception e)
            {
                MessageBox.Show("Không thể kết nối đến database!!!\nChi tiết: " + e.Message);
            }
        }

        public List<Book> getListBook()
        {
            if (!isOpen)
            {
                openConnection();
            }
            List<Book> result = new List<Book>();
            string query = "SELECT TOP 50 * FROM BOOK WHERE RENT_STATUS != 2";
            
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book temp = new Book(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), Int32.Parse(reader[3].ToString()), reader[4].ToString(), 
                        reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(),
                        reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(),
                        reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString());

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể lấy dữ liệu!!!\nChi tiết: " + e.Message);
            }
            
            return result;
        }
    }
}
