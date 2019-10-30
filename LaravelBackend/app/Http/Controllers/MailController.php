<?php
namespace App\Http\Controllers;

use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\SMTP;
use PHPMailer\PHPMailer\Exception;
use Illuminate\Support\Facades\DB;

require __DIR__.'/../../../vendor/autoload.php';

class MailController
{
    public function NotifyUser(){
        $lektioner = \App\Lektion::all();
        foreach($lektioner as $lektion){
            $hoved = $lektion->hoved;
            if(DB::table('users')->where('hoved', $hoved)->count() > 0){
                $users = DB::table('users')->where('hoved', $hoved)->get();
                foreach($users as $user){
                    $this->SendMail($user, $lektion);
                }
            }
        }
    }
    public function SendMail($user, $lektion)
    {
        $usermail = $user->mail;
        $username = $user->name;
        $mail = new PHPMailer();
        try {
            //Server settings
            $mail->SMTPDebug = SMTP::DEBUG_SERVER;                      // Enable verbose debug output
            $mail->isSMTP();                                            // Send using SMTP
            $mail->Port       = 587;                                    // TCP port to connect to
            $mail->Host       = 'smtp.gmail.com';                    // Set the SMTP server to send through
            $mail->SMTPAuth   = true;                                   // Enable SMTP authentication
            $mail->Username   = env('MAIL_USERNAME');                     // SMTP username
            $mail->Password   = env('MAIL_PASSWORD');                               // SMTP password
            $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS;         // Enable TLS encryption; `PHPMailer::ENCRYPTION_SMTPS` also accepted
        
            //Recipients
            $mail->setFrom(env('MAIL_USERNAME'), 'SKOLESKEMA');
            $mail->addAddress($usermail, $username);     // Add a recipient
            // Content
            $mail->isHTML(true);                                  // Set email format to HTML
            $mail->Subject = 'Hi '.$username.' NOGGA';
            $mail->Body    = 'This is the HTML message body <b>in bold!</b>';
            $mail->AltBody = 'This is the body in plain text for non-HTML mail clients';
        
            $mail->send();
            echo 'Message has been sent';
        } catch (Exception $e) {
            echo "Message could not be sent. Mailer Error: {$mail->ErrorInfo}";
        }
    }
}