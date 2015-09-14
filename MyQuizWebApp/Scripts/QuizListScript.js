
(function ($)
{
    $(function ()
    {
        $(".sortAsc").click(function (e)
        {
            listView.get_sortExpressions().clear();
            listView.sort(fieldsCombo.get_value(), "ASC");
        });
        $(".sortDesc").click(function (e)
        {
            listView.get_sortExpressions().clear();
            listView.sort(fieldsCombo.get_value(), "DESC");
        });
 
        $(".pagePrev").click(function (e)
        {
            listView.page(listView.get_currentPageIndex() - 1);
        });
        $(".pageNext").click(function (e)
        {
            listView.page(listView.get_currentPageIndex() + 1);
        });
 
        $("#listView").on("click", ".item", function (e)
        {
            listView.toggleSelection($(this).index());
        });
    });
})($telerik.$);
 
function onListViewDataBinding(sender, args)
{
    sender.set_selectedIndexes([]);
}
 
function onListViewDataBound(sender, args)
{
    $telerik.$(".pagePrev").css("display", sender.get_currentPageIndex() === 0 ? "none" : "");
    $telerik.$(".pageNext").css("display", sender.get_currentPageIndex() === sender.get_pageCount() - 1 ? "none" : "");
}
 
function onSearchButtonClick(sender, args)
{
    var value = searchBox.get_value();
    listView.set_currentPageIndex(0);
    if (value)
    {
        listView.get_filterExpressions().clear();
        listView.filter(fieldsCombo.get_value(), Telerik.Web.UI.RadListViewFilterFunction.Contains, value);
    }
    else
    {
        listView.clearFilter();
    }
}
 
function onSearchBoxKeyPress(sender, args)
{
    if (args.get_keyCode() === 13)
    {
        searchButton.click();
    }
}