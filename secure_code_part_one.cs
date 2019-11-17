# Insecure C# from "Secure code warrior" excerises.

 int frequentFligherPoints = price / 10;
        StoreFrequentFligherPoints(customerEmail, frequentFligherPoints);
		
# The above code should not be executed server side.

        int frequentFligherPoints = price / 10;
        StoreFrequentFligherPoints(customerEmail, frequentFligherPoints);
		
# The above code can be fixed with this code below.

  int frequentFligherPoints = Int32.Parse(Session["totalPrice"].ToString()) / 10;
        StoreFrequentFligherPoints(Session["userEmail"].ToString(), frequentFligherPoints);
		
# Better to parse information through the server, using sessions.

