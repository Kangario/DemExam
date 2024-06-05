# DemExam
  public List<UserData> ConnectionToDb()
        {
            string basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string currentDB = "Data Source=" + basePath + connectionString;
            List<UserData> users = new List<UserData>();
            using (var connection = new SqliteConnection(currentDB))
            {
                connection.Open();

                string sql = "SELECT * FROM Client";

                using (var command = new SqliteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserData user = new UserData();
                            user.ID = reader.GetInt32(0);
                            user.Name = reader.GetString(1);
                            user.Password = reader.GetString(2);
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }
