// JavaScript source code
function generateTable() {
    $(document).ready(function() {
        $.get("txt/books.xml", function(d) {
            var data = "";
            //Defining table header row
            var startTag = "<table><caption>Book List</caption><tr><th>Code</th><th>BookName</th><th>Category</th><th>Price</th></tr>";
            var endTag = "</table>";
            //Extracting from XML file into the table
            $(d)
                .find("List")
                .each(function() {
                    var $url = $(this);
                    var Code = $url.find("Code").text();
                    var BookName = $url.find("BookName").text();
                    var Category = $url.find("Category").text();
                    var Price = $url.find("Price").text();
                    data += "<tr><td>" + Code + "</td>";
                    data += "<td>" + BookName + "</td>";
                    data += "<td>" + Category + "</td>";
                    data += '<td  style="text-align: right">' + Price + "</td></tr>";
                });
            // Writing to the HTML page
            $("#content").html(startTag + data + endTag);
        });
    });
}
