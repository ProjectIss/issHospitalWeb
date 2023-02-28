function ApplyNormalGridStyle() {
    var table = $('.table');
    var oTable = table.dataTable({
        "paging": false,
        "ordering": false,
        "searching": false
    });
    var tableWrapper = $('.datatable_wrapper'); // datatable creates the table wrapper by adding with id {your_table_jd}_wrapper


}

/* Set the defaults for DataTables initialisation */
$.extend(true, $.fn.dataTable.defaults, {
    "dom": "<'row'<'col-md-6 col-sm-12'l><'col-md-6 col-sm-12'f>r><'table-scrollable't><'row'<'col-xl-6 col-md-12 col-sm-12'i><'col-xl-6 col-md-12 col-sm-12'p>>", // default layout with horizobtal scrollable datatable   
});