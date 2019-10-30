<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\User;
use App\Lektion;
use Illuminate\Support\Facades\DB;

class UserHandler extends Controller
{
        
    //
    public function CreateUser(Request $request){
        /*if($request['token'] != $apikey){
            return "API-KEY not valid";
        }*/
        $user = new User;
        $user->email = $request['email'];
        $user->name = $request['name'];
        $user->hoved = $request['hoved'];
        $user->save();
    }

    public function GetUsers(Request $request){
        if($request['token'] != $apikey){
            return "API-KEY not valid";
        }
        return User::all();
    }
    public function GetUserGroup(Request $request){
        $useremails = DB::table('users')->select('email', 'name')->where('hoved', $request['hoved'])->get();
        $emails = [];
        foreach($useremails as $email){
            array_push($emails, $email->email);
        }
        return $useremails;
        //User::all()->select('email')->where('hoved', $request['hoved'])[0];
    }

    public function AddClass(Request $request){
        $class = new Lektion;
        $class->name = $request['name'];
        $class->hoved = $request['hoved'];
        $class->location = $request['location'];
        $class->hour = $request['hour'];
        $class->save();
    }
}
