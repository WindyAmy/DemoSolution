//require.config({
//    paths: {
//        "jquery": ["http://libs.baidu.com/jquery/2.0.3/jquery"],
//        "a": "a",
//        "b":"b"
//    }
//})
////require(["jquery", "a"], function ($) {
////    $(function () {
////        alert("load finished");
////    })
////})
//require(["a"], function (b) {
//    fun1("alert from a");
    
//    //$(function () {
//    //    alert("load finished");
//    //})
//})

require(["student", "class"], function (student, clz) {

    clz.addToClass(student.createStudent("Jack", "male"));

    clz.addToClass(student.createStudent("Rose", "female"));

    console.log(clz.getClassSize()); // 输出 2  
    console.log(clz.allStudents);

});