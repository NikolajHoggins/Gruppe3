<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome')->with('lektioner', \App\Lektion::all());
});

Route::get('/adduser/{name}/{email}/{hoved}', 'UserHandler@CreateUser');
Route::get('/getusers/{token}/', 'UserHandler@GetUsers');

Route::get('/yeet', 'MailController@NotifyUser');
Route::get('/getusergroup/{token}/{hoved}', 'UserHandler@GetUserGroup');
Route::get('/addclass/{token}/{hoved}/{hour}/{location}/{name}', 'UserHandler@AddClass');

